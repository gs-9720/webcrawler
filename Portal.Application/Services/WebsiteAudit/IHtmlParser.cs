using AngleSharp.Dom;

namespace Portal.Application.Services.WebsiteAudit;
public interface IHtmlParser
{
    IDocument Parse(string html);
}
