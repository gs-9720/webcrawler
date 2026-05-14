
using Microsoft.EntityFrameworkCore;
using Portal.Domain.Users;

namespace Portal.Infrastructure.Data.Repositories;

public class UserRepository
    : Repository<User>, IUserRepository
{
    public UserRepository(PortalDbContext db) : base(db) { }

    public Task<User?> GetByEmailAsync(string email)
    {
        return _db.Users.FirstOrDefaultAsync(x => x.Email == email);
    }
}