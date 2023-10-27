using CarCatalog.Domain.Common.BaseEntities;

namespace CarCatalog.Domain.Entities;

public class Photo : AuditableBaseEntity
{
    public Guid CarId { get; set; }
    public Car Car { get; set; }
    
    public string PhotoURL { get; set; }
}