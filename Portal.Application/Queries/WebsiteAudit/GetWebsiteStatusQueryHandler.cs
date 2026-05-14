using MediatR;
using Portal.Application.Services.WebsiteAudit;

namespace Portal.Application.Queries.WebsiteAudit;

public class AuditWebsiteQueryHandler
    : IRequestHandler<AuditWebsiteQuery, PageAnalysisResult>
{
    private readonly IPageFetcher _fetcher;
    private readonly IHtmlParser _parser;
    private readonly IPageAnalyzer _analyzer;
    private readonly IScorer _scorer;

    public AuditWebsiteQueryHandler(
        IPageFetcher fetcher,
        IHtmlParser parser,
        IPageAnalyzer analyzer,
        IScorer scorer)
    {
        _fetcher = fetcher;
        _parser = parser;
        _analyzer = analyzer;
        _scorer = scorer;
    }

    public async Task<PageAnalysisResult> Handle(
        AuditWebsiteQuery request,
        CancellationToken cancellationToken)
    {
        var (html, loadMs) = await _fetcher.FetchAsync(request.Url);
        var document = _parser.Parse(html);

        var result = _analyzer.Analyze(
            request.Url,
            PageType.Homepage,
            document,
            loadMs);

        result.Score = _scorer.Calculate(result);

        return result;
    }
}