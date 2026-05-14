using System.Diagnostics;
using System.Net.Http.Headers;

namespace Portal.Application.Services.WebsiteAudit;
public class PageFetcher : IPageFetcher
{
    private readonly HttpClient _client;

    public PageFetcher(HttpClient client)
    {
        client.Timeout = TimeSpan.FromSeconds(10);
        client.DefaultRequestHeaders.UserAgent.Add(
            new ProductInfoHeaderValue("WebsiteCrawler", "1.0"));

        _client = client;
    }

    public async Task<(string Html, long LoadMs)> FetchAsync(string url)
    {
        var sw = Stopwatch.StartNew();
        var html = await _client.GetStringAsync(url);
        sw.Stop();

        return (html, sw.ElapsedMilliseconds);
    }
}