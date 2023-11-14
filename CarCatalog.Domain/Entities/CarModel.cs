using CarCatalog.Domain.Common.BaseEntities;

namespace CarCatalog.Domain.Entities;

public class CarModel : BaseEntity
{
    public Guid BrandId { get; set; }
    public  Brand Brand { get; set; }
    
    public string Name { get; set; }
    
    public List<Car> Cars { get; set; }
}