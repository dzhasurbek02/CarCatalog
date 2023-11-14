using CarCatalog.Domain.Entities;
using CarCatalog.Persistence.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Configurations.BodyStyles;

public class BodyStyleConfiguration : IEntityTypeConfiguration<BodyStyle>
{
    public void Configure(EntityTypeBuilder<BodyStyle> builder)
    {
        builder.HasKey(bs => bs.Id);
        
        builder.Property(bs => bs.Name)
            .IsRequired()
            .HasMaxLength(30);
        
        BodyStyleSeeder.SeedBodyStyles(builder);
    }
}