using CarCatalog.Domain.Entities;
using CarCatalog.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Seeders;

public static class TransmissionSeeder
{
    public static void SeedTransmissions(EntityTypeBuilder<Transmission> builder)
    {
        builder.HasData(
            new Transmission { Id = TransmissionEnum.Automatic.Value, Name = TransmissionEnum.Automatic.Name },
            new Transmission { Id = TransmissionEnum.Manual.Value, Name = TransmissionEnum.Manual.Name });
    }
}