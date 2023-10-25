namespace CarCatalog.Domain.Common.BaseEntities;

public class AuditableBaseEntity : BaseEntity
{
    public DateTime CreatedDateTime { get; set; }

    public DateTime? UpdatedDateTime { get; set; }

    public DateTime? DeletedDateTime { get; set; }
    
    public Guid CreatedByUserId { get; set; }
    
    public Guid? UpdatedByUserId { get; set; }
    
    public Guid? DeletedByUserId { get; set; }
}