namespace CarCatalog.Domain.Common.BaseEntities;

public abstract class AuditableBaseEntity : BaseEntity
{
    public DateTime CreatedDateTime { get; set; }

    public DateTime? UpdatedDateTime { get; set; }

    public Guid CreatedByUserId { get; set; }
    
    public Guid? UpdatedByUserId { get; set; }
}