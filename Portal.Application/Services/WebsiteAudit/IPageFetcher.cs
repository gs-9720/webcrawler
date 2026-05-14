namespace Portal.Application.Services.WebsiteAudit;

public interface IPageFetcher
{
    Task<(string Html, long LoadMs)> FetchAsync(string url);
}