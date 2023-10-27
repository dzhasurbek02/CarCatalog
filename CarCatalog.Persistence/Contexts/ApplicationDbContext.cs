using System.Reflection;
using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Persistence.Contexts;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    public DbSet<BodyStyle> BodyStyles { get; set; }
    
    public DbSet<Brand> Brands { get; set; }
    
    public DbSet<Car> Cars { get; set; }
    
    public DbSet<CarColor> CarColors { get; set; }
    
    public DbSet<CarFeature> CarFeatures { get; set; }
    
    public DbSet<CarModel> CarModels { get; set; }
    
    public DbSet<DriveTrain> DriveTrains { get; set; }
    
    public DbSet<Feature> Features { get; set; }
    
    public DbSet<FuelType> FuelTypes { get; set; }
    
    public DbSet<Photo> Photos { get; set; }
    
    public DbSet<Transmission> Transmissions { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        base.OnModelCreating(builder);
    }

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}