using MediatR;

namespace Portal.Application.Queries.WebsiteAudit;

public record AuditWebsiteQuery(string Url)
    : IRequest<PageAnalysisResult>;