using CarCatalog.Domain.Entities;
using CarCatalog.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Seeders;

public class DriveTrainSeeder
{
    public static void SeedDriveTrain(EntityTypeBuilder<DriveTrain> builder)
    {
        builder.HasData(
            new DriveTrain { Id = DriveTrainEnum.FWD.Value, Name = DriveTrainEnum.FWD.Name },
            new DriveTrain { Id = DriveTrainEnum.RWD.Value, Name = DriveTrainEnum.RWD.Name },
            new DriveTrain { Id = DriveTrainEnum.AWD.Value, Name = DriveTrainEnum.AWD.Name });
    }
}