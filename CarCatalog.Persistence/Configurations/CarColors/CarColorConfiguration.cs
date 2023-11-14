using CarCatalog.Domain.Entities;
using CarCatalog.Persistence.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Configurations.CarColors;

public class CarColorConfiguration : IEntityTypeConfiguration<CarColor>
{
    public void Configure(EntityTypeBuilder<CarColor> builder)
    {
        builder.HasKey(col => col.Id);
        
        builder.Property(col => col.Name)
            .IsRequired()
            .HasMaxLength(50);
        
        CarColorSeeder.SeedCarColors(builder);
    }
}