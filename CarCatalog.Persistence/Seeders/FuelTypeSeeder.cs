using CarCatalog.Domain.Entities;
using CarCatalog.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Seeders;

public class FuelTypeSeeder
{
    public static void SeedFuelType(EntityTypeBuilder<FuelType> builder)
    {
        builder.HasData(
            new FuelType { Id = FuelTypeEnum.Petrol.Value, Name = FuelTypeEnum.Petrol.Name },
            new FuelType { Id = FuelTypeEnum.Diesel.Value, Name = FuelTypeEnum.Diesel.Name });
    }
}