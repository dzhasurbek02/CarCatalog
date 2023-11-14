using CarCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Configurations.CarFeatures;

public class CarFeatureConfiguration : IEntityTypeConfiguration<CarFeature>
{
    public void Configure(EntityTypeBuilder<CarFeature> builder)
    {
        builder.HasKey(cf => cf.Id);
        
        builder.HasOne(cf => cf.Car)
            .WithMany(c => c.CarFeatures)
            .HasForeignKey(cf => cf.CarId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

        builder.HasOne(cf => cf.Feature)
            .WithMany(f => f.CarFeatures)
            .HasForeignKey(cf => cf.FeatureId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();
    }
}