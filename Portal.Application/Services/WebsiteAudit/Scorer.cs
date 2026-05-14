using Portal.Application.Queries.WebsiteAudit;

namespace Portal.Application.Services.WebsiteAudit;

public class Scorer : IScorer
{
    public int Calculate(PageAnalysisResult r)
    {
        int score = 0;

        if (r.ContentClarity.ValuePropAboveFold)
            score += 25;

        if (r.Conversion.PrimaryCtaAboveFold)
            score += 25;

        if (r.Conversion.HasContactForm)
            score += 15;

        if (r.Technical.MobileFriendly)
            score += 15;

        if (r.Technical.PageLoadMs < 1500)
            score += 10;

        if (r.Technical.IsHttps)
            score += 10;

        return Math.Min(score, 100);
    }
}