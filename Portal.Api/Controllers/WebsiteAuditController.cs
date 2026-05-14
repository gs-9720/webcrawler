using Microsoft.AspNetCore.Mvc;


using MediatR;
using Portal.Application.Queries.WebsiteAudit;

[ApiController]
[Route("api/website-audit")]

public class WebsiteAuditController : ControllerBase
{

    private readonly IMediator _mediator;

    public WebsiteAuditController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Audit([FromQuery] string url)
    {
        return Ok(await _mediator.Send(new AuditWebsiteQuery(url)));
    }

}
