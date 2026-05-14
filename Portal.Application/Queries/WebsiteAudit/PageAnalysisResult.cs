namespace Portal.Application.Queries.WebsiteAudit;

// public public class WebsiteReadModel
// {
//     public Guid Id { get; init; }
//     public string Name { get; init; }= string.Empty;
//     public string Email { get; init; } = string.Empty;
// }



public enum PageType
{
    Homepage,
    Landing,
    Blog,
    Pricing,
    Other
}



public class PageAnalysisResult
{
    public string Url { get; set; } = "";
    public PageType PageType { get; set; }

    public StructuralData Structure { get; set; } = new();
    public ContentClarityData ContentClarity { get; set; } = new();
    public ConversionData Conversion { get; set; } = new();
    public TechnicalData Technical { get; set; } = new();

    public int Score { get; set; }
}

public class StructuralData
{
    public string? Title { get; set; }
    public string? MetaDescription { get; set; }
    public List<string> H1s { get; set; } = [];
    public List<string> H2s { get; set; } = [];
    public List<string> InternalLinks { get; set; } = [];
    public List<CtaElement> Ctas { get; set; } = [];
}

public class CtaElement
{
    public string Text { get; set; } = "";
    public string Target { get; set; } = "";
    public bool AboveFold { get; set; }
}

public class ContentClarityData
{
    public bool ValuePropAboveFold { get; set; }
    public string AudienceType { get; set; } = "Unknown";
    public double BenefitFeatureRatio { get; set; }
}

public class ConversionData
{
    public bool PrimaryCtaAboveFold { get; set; }
    public bool HasSecondaryCtas { get; set; }
    public bool HasContactForm { get; set; }
    public bool PricingVisible { get; set; }
}

public class TechnicalData
{
    public bool IsHttps { get; set; }
    public bool HasCanonical { get; set; }
    public bool MobileFriendly { get; set; }
    public long PageLoadMs { get; set; }
}

