using MediatR;

namespace Portal.Application.Commands.User;

public record CreateUserCommand(
    string Name,
    string Email) : IRequest<Guid>;