using CarCatalog.Domain.Entities;
using CarCatalog.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Seeders;

public class TransmissionSeeder
{
    public static void SeedTransmission(EntityTypeBuilder<Transmission> builder)
    {
        builder.HasData(
            new Transmission { Id = TransmissionEnum.Automatic.Value, Name = TransmissionEnum.Automatic.Name },
            new Transmission { Id = TransmissionEnum.Manual.Value, Name = TransmissionEnum.Manual.Name });
    }
}