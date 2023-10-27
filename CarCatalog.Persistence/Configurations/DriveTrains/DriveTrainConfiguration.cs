using CarCatalog.Domain.Entities;
using CarCatalog.Persistence.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Configurations.DriveTrains;

public class DriveTrainConfiguration : IEntityTypeConfiguration<DriveTrain>
{
    public void Configure(EntityTypeBuilder<DriveTrain> builder)
    {
        builder.HasKey(dt => dt.Id);
        
        builder.Property(dt => dt.Name)
            .IsRequired()
            .HasMaxLength(30);
        
        DriveTrainSeeder.SeedDriveTrain(builder);
    }
}