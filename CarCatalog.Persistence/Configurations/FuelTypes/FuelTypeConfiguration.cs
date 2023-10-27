using CarCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Configurations.FuelTypes;

public class FuelTypeConfiguration : IEntityTypeConfiguration<FuelType>
{
    public void Configure(EntityTypeBuilder<FuelType> builder)
    {
        builder.HasKey(ft => ft.Id);
        
        builder.Property(ft => ft.Name)
            .IsRequired()
            .HasMaxLength(30);
    }
}