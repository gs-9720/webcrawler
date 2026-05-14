using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Portal.Common.Logging;
using Portal.Domain.Shared;
using Portal.Domain.Users;
using Portal.Infrastructure.Data;
using Portal.Infrastructure.Data.Repositories;
using Portal.Infrastructure.Logging;



namespace Portal.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        string connectionString)
    {
        services.AddDbContext<PortalDbContext>(
            x => x.UseSqlServer(connectionString));

        services.AddScoped<IUnitOfWork>(
            sp => sp.GetRequiredService<PortalDbContext>());


        services.AddScoped<IUserRepository, UserRepository>();
        services.AddSingleton<ILogger, FileLogger>();

        return services;
    }
}