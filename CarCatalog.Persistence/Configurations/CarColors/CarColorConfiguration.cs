using CarCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Configurations.CarColors;

public class CarColorConfiguration : IEntityTypeConfiguration<CarColor>
{
    public void Configure(EntityTypeBuilder<CarColor> builder)
    {
        builder.HasKey(col => col.Id);
        
        builder.Property(col => col.Name)
            .IsRequired()
            .HasMaxLength(50);

        /*builder.HasData(
            new CarColor { Id = CarColorEnum.Black.Value, Name = CarColorEnum.Black.Name },
            new CarColor { Id = CarColorEnum.White.Value, Name = CarColorEnum.White.Name },
            new CarColor { Id = CarColorEnum.Gray.Value, Name = CarColorEnum.Gray.Name },
            new CarColor { Id = CarColorEnum.Blue.Value, Name = CarColorEnum.Blue.Name },
            new CarColor { Id = CarColorEnum.Red.Value, Name = CarColorEnum.Red.Name });*/
    }
}