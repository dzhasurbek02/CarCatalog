using CarCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Configurations.Brands;

public class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.HasKey(b => b.Id);
        
        builder.Property(b => b.Name)
            .IsRequired()
            .HasMaxLength(30);

        /*builder.HasData(
            new Brand { Id = BrandEnum.Mercedes.Value, Name = BrandEnum.Mercedes.Name },
            new Brand { Id = BrandEnum.BMW.Value, Name = BrandEnum.BMW.Name },
            new Brand { Id = BrandEnum.Toyota.Value, Name = BrandEnum.Toyota.Name });*/
    }
}