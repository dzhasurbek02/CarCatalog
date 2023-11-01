using CarCatalog.Domain.Common.BaseEntities;

namespace CarCatalog.Domain.Entities;

public class CarPhoto : AuditableBaseEntity
{
    public Guid CarId { get; set; }
    public Car Car { get; set; }
    public List<string> PhotoURL { get; set; } = new List<string>();
}