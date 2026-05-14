using MediatR;

namespace Portal.Application.Queries.Users;

public record GetUserByIdQuery(Guid Id)
    : IRequest<UserReadModel>;