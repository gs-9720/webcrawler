using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portal.Application.Commands.User;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserRequest request)
    {
        var  rec=  new CreateUserCommand(request.Name, request.Email);
        return Ok(await _mediator.Send(rec));
    }
}