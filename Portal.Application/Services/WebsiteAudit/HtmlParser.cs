using AngleSharp;
using AngleSharp.Dom;

namespace Portal.Application.Services.WebsiteAudit;
public class HtmlParser : IHtmlParser
{
    public IDocument Parse(string html)
    {
        var context = BrowsingContext.New(Configuration.Default);
        return context.OpenAsync(r => r.Content(html)).Result;
    }
}