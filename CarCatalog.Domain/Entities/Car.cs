using CarCatalog.Domain.Common.BaseEntities;

namespace CarCatalog.Domain.Entities;

public class Car : AuditableBaseEntity
{
    public Guid BrandId { get; set; }
    public Brand Brand { get; set; }
    
    public Guid CarModelId { get; set; }
    public CarModel CarModel { get; set; }
    
    public Guid BodyStyleId { get; set; }
    public BodyStyle BodyStyle { get; set; }
    
    public short Year { get; set; }
    
    public string Set { get; set; }
    
    public float EngineCapacity { get; set; }
    
    public ushort HorsePower { get; set; }
    
    public Guid FuelTypeId { get; set; }
    public FuelType FuelType { get; set; }
    
    public Guid TransmissionId { get; set; }
    public Transmission Transmission { get; set; }
    
    public Guid DriveTrainId { get; set; }
    public DriveTrain DriveTrain { get; set; }
    
    public Guid CarColorId { get; set; }
    public CarColor CarColor { get; set; }
    
    public string? Description { get; set; }
    
    public float Price { get; set; }
    
    public List<Photo>? Photos { get; set; }
    
    public List<CarFeature>? CarFeatures { get; set; }
}