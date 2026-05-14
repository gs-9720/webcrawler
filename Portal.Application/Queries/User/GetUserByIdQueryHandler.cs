using MediatR;
using Microsoft.EntityFrameworkCore;
using Portal.Infrastructure.Data;

namespace Portal.Application.Queries.Users;

public class GetUserByIdQueryHandler
    : IRequestHandler<GetUserByIdQuery, UserReadModel>
{
    private readonly PortalDbContext _db;

    public GetUserByIdQueryHandler(PortalDbContext db)
    {
        _db = db;
    }

    public async Task<UserReadModel> Handle(
        GetUserByIdQuery request,
        CancellationToken cancellationToken)
    {
        return await _db.Users
            .Where(x => x.Id == request.Id)
            .Select(x => new UserReadModel
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email
            })
            .FirstAsync(cancellationToken);
    }
}