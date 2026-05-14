using System.Text.RegularExpressions;
using AngleSharp.Dom;
using Portal.Application.Queries.WebsiteAudit;

namespace Portal.Application.Services.WebsiteAudit;

public class PageAnalyzer : IPageAnalyzer
{
    private static readonly Regex CtaRegex =
        new("(get started|demo|book|contact|pricing|trial)",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

    private static readonly string[] BenefitWords =
        { "increase", "reduce", "save", "grow", "improve" };

    private static readonly string[] FeatureWords =
        { "dashboard", "api", "integration", "feature" };

    public PageAnalysisResult Analyze( string url, PageType pageType, IDocument doc, long loadMs)
    {
        var result = new PageAnalysisResult
        {
            Url = url,
            PageType = pageType
        };

        // =======================
        // STRUCTURE
        // =======================
        result.Structure.Title = doc.Title;

        result.Structure.MetaDescription = doc.QuerySelector("meta[name='description']")?.GetAttribute("content");

        result.Structure.H1s = doc.QuerySelectorAll("h1")
            .Select(h => h.TextContent.Trim())
            .Where(s => !string.IsNullOrWhiteSpace(s))
            .ToList();

        result.Structure.H2s = doc.QuerySelectorAll("h2")
            .Select(h => h.TextContent.Trim())
            .Where(s => !string.IsNullOrWhiteSpace(s))
            .ToList();

        var host = new Uri(url).Host;

        result.Structure.InternalLinks = doc
            .QuerySelectorAll("a[href]")
            .Select(a => a.GetAttribute("href")!)
            .Where(h =>
                h.StartsWith("/") ||
                h.Contains(host, StringComparison.OrdinalIgnoreCase))
            .Distinct()
            .ToList();

        // =======================
        // CTA DETECTION
        // =======================
        result.Structure.Ctas = doc
            .QuerySelectorAll("a, button")
            .Where(e => !string.IsNullOrWhiteSpace(e.TextContent))
            .Where(e => CtaRegex.IsMatch(e.TextContent))
            .Select(e => new CtaElement
            {
                Text = e.TextContent.Trim(),
                Target = e.GetAttribute("href") ?? "",
                AboveFold = e.SourceReference?.Position.Line < 40
            })
            .ToList();

        // =======================
        // CONTENT CLARITY
        // =======================
        var bodyText = doc.Body?.TextContent ?? string.Empty;
        var aboveFoldText = bodyText[..Math.Min(800, bodyText.Length)];

        result.ContentClarity.ValuePropAboveFold =
            Regex.IsMatch(
                aboveFoldText,
                "(helps|for|without|increase|improve)",
                RegexOptions.IgnoreCase);

        result.ContentClarity.AudienceType =
            Regex.IsMatch(bodyText,
                "(enterprise|workflow|roi|team|saas)",
                RegexOptions.IgnoreCase)
                ? "B2B"
                : "B2C";

        int benefitCount = BenefitWords
            .Count(w => bodyText.Contains(w,
                StringComparison.OrdinalIgnoreCase));

        int featureCount = FeatureWords
            .Count(w => bodyText.Contains(w,
                StringComparison.OrdinalIgnoreCase));

        result.ContentClarity.BenefitFeatureRatio =
            featureCount == 0
                ? benefitCount
                : Math.Round((double)benefitCount / featureCount, 2);

        // =======================
        // CONVERSION
        // =======================
        result.Conversion.PrimaryCtaAboveFold =
            result.Structure.Ctas.Any(c => c.AboveFold);

        result.Conversion.HasSecondaryCtas =
            result.Structure.Ctas.Count > 1;

        result.Conversion.HasContactForm =
            doc.QuerySelectorAll("form")
               .Any(f =>
                   f.TextContent.Contains("email",
                       StringComparison.OrdinalIgnoreCase));

        result.Conversion.PricingVisible =
            Regex.IsMatch(
                bodyText,
                "(₹|\\$|pricing|plans)",
                RegexOptions.IgnoreCase);

        // =======================
        // TECHNICAL
        // =======================
        result.Technical.IsHttps =
            url.StartsWith("https", StringComparison.OrdinalIgnoreCase);

        result.Technical.HasCanonical =
            doc.QuerySelector("link[rel='canonical']") != null;

        result.Technical.MobileFriendly =
            doc.QuerySelector("meta[name='viewport']") != null;

        result.Technical.PageLoadMs = loadMs;

        return result;
    }
}
