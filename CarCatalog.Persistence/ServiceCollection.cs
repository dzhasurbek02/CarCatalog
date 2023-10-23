using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarCatalog.Persistence;

public static class ServiceCollection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(opt =>
            opt.UseNpgsql("Host=localhost;Port=5432;Database=CarsFinal;Username=postgres;Password=root"));
        
        services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

        return services;
    }
}