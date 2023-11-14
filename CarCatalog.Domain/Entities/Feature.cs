using CarCatalog.Domain.Common.BaseEntities;

namespace CarCatalog.Domain.Entities;

public class Feature : AuditableBaseEntity
{
    public string Name { get; set; }
    
    public List<CarFeature>? CarFeatures { get; set; }
}