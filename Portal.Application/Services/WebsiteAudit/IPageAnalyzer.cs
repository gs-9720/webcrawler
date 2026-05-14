
using AngleSharp.Dom;
using Portal.Application.Queries.WebsiteAudit;

namespace  Portal.Application.Services.WebsiteAudit;
public interface IPageAnalyzer
{
    PageAnalysisResult Analyze(
        string url,
        PageType pageType,
        IDocument doc,
        long loadMs);
}
