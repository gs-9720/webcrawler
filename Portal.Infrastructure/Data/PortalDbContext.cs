using Microsoft.EntityFrameworkCore;
using Portal.Domain.Shared;
using Portal.Domain.Users;

namespace Portal.Infrastructure.Data;

public class PortalDbContext : DbContext, IUnitOfWork
{
    public DbSet<User> Users => Set<User>();

    public PortalDbContext(DbContextOptions<PortalDbContext> options)
        : base(options) { }

    public Task<int> SaveChangesAsync(
        CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}