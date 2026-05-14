using Microsoft.EntityFrameworkCore;
using Portal.Domain.Shared;

namespace Portal.Infrastructure.Data.Repositories;

public class Repository<T> : IRepository<T>
    where T : Entity
{
    protected readonly PortalDbContext _db;

    public Repository(PortalDbContext db)
    {
        _db = db;
    }

    public async Task AddAsync(T entity)
    {
        await _db.Set<T>().AddAsync(entity);
    }

    public Task UpdateAsync(T entity)
    {
        _db.Set<T>().Update(entity);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(T entity)
    {
        _db.Set<T>().Remove(entity);
        return Task.CompletedTask;
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _db.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> GetAllAsync()
    {
        return await _db.Set<T>()
            .AsNoTracking()
            .ToListAsync();
    }
}