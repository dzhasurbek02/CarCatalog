using CarCatalog.Domain.Entities;
using CarCatalog.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Seeders;

public static class BodyStyleSeeder
{
    public static void SeedBodyStyles(EntityTypeBuilder<BodyStyle> builder)
    {
        builder.HasData(
            new BodyStyle { Id = BodyStyleEnum.Sedan.Value, Name = BodyStyleEnum.Sedan.Name },
            new BodyStyle { Id = BodyStyleEnum.Hatchback.Value, Name = BodyStyleEnum.Hatchback.Name },
            new BodyStyle { Id = BodyStyleEnum.Coupe.Value, Name = BodyStyleEnum.Coupe.Name });
    }
}