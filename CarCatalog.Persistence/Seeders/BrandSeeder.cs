using CarCatalog.Domain.Entities;
using CarCatalog.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Seeders;

public class BrandSeeder
{
    public static void SeedBrands(EntityTypeBuilder<Brand> builder)
    {
        builder.HasData(
            new Brand { Id = BrandEnum.Mercedes.Value, Name = BrandEnum.Mercedes.Name },
            new Brand { Id = BrandEnum.BMW.Value, Name = BrandEnum.BMW.Name },
            new Brand { Id = BrandEnum.Toyota.Value, Name = BrandEnum.Toyota.Name });
    }
}