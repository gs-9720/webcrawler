// using Portal.Domain.Users;

// namespace Portal.Infrastructure.Data.Repository;

// public class UserRepository : IUserRepository
// {
//     private readonly PortalDbContext _db;

//     public async Task AddAsync(User user)
//     {
//         _db.Users.Add(user);
//         await _db.SaveChangesAsync();
//     }

//     public async Task<User?> GetByIdAsync(Guid id)
//     {
//         return await _db.Users.FindAsync(id);
//     }

//        public async   Task<User?> GetByEmailAsync(string email)
//        {
//          return await _db.Users.FindAsync(email);
    
//        }
// }