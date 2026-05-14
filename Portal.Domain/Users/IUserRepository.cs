using Portal.Domain.Shared;

namespace Portal.Domain.Users;

public interface IUserRepository : IRepository<User>
{
    Task<User?> GetByEmailAsync(string email);
}