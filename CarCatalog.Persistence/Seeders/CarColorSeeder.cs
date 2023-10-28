using CarCatalog.Domain.Entities;
using CarCatalog.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Seeders;

public static class CarColorSeeder
{
    public static void SeedCarColors(EntityTypeBuilder<CarColor> builder)
    {
        builder.HasData(
            new CarColor { Id = CarColorEnum.Black.Value, Name = CarColorEnum.Black.Name },
            new CarColor { Id = CarColorEnum.White.Value, Name = CarColorEnum.White.Name },
            new CarColor { Id = CarColorEnum.Gray.Value, Name = CarColorEnum.Gray.Name },
            new CarColor { Id = CarColorEnum.Blue.Value, Name = CarColorEnum.Blue.Name },
            new CarColor { Id = CarColorEnum.Red.Value, Name = CarColorEnum.Red.Name });
    }
}