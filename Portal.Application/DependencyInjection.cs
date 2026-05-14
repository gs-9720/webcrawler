using Microsoft.Extensions.DependencyInjection;
using Portal.Application.Services.WebsiteAudit;

public static class DependencyInjection
{
    public static IServiceCollection AddWebsiteAudit(
        this IServiceCollection services)
    {
        services.AddHttpClient();

        services.AddScoped<IPageFetcher, PageFetcher>();
        services.AddScoped<IHtmlParser, HtmlParser>();
        services.AddScoped<IPageAnalyzer, PageAnalyzer>();
        services.AddScoped<IScorer, Scorer>();

        return services;
    }
}