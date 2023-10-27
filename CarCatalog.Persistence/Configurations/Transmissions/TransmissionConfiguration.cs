using CarCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarCatalog.Persistence.Configurations.Transmissions;

public class TransmissionConfiguration : IEntityTypeConfiguration<Transmission>
{
    public void Configure(EntityTypeBuilder<Transmission> builder)
    {
        builder.HasKey(t => t.Id);
        
        builder.Property(t => t.Name)
            .IsRequired()
            .HasMaxLength(30);
    }
}