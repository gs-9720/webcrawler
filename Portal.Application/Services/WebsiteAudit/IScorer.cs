using Portal.Application.Queries.WebsiteAudit;

namespace Portal.Application.Services.WebsiteAudit;


public interface IScorer
{
    int Calculate(PageAnalysisResult result);
}
