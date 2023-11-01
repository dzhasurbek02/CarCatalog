using CarCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Configurations.CarPhotos;

public class CarPhotoConfiguration : IEntityTypeConfiguration<CarPhoto>
{
    public void Configure(EntityTypeBuilder<CarPhoto> builder)
    {
        builder.HasKey(p => p.Id);
        
        builder.HasOne<Car>(p => p.Car)
            .WithMany(c => c.Photos)
            .HasForeignKey(p => p.CarId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(p => p.PhotoURL)
            .IsRequired();
    }
}