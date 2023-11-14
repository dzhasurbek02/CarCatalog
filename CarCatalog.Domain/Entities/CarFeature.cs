using CarCatalog.Domain.Common.BaseEntities;

namespace CarCatalog.Domain.Entities;

public class CarFeature : BaseEntity
{
    public Guid CarId { get; set; }
    public Car Car { get; set; }
    
    public Guid FeatureId { get; set; }
    public Feature Feature { get; set; }
}