using CarCatalog.Domain.Common.BaseEntities;

namespace CarCatalog.Domain.Entities;

public class FuelType : BaseEntity
{
    public string Name { get; set; }
    
    public List<Car> Cars { get; set; }
}