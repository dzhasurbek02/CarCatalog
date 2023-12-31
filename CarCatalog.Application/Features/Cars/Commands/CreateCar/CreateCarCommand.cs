using CarCatalog.Application.Features.Features.Queries.GetAllFeatures;
using MediatR;

namespace CarCatalog.Application.Features.Cars.Commands.CreateCar;

public class CreateCarCommand : IRequest<Guid>
{
    public Guid BrandId { get; set; }
    
    public Guid CarModelId { get; set; }
    
    public Guid BodyStyleId { get; set; }
    
    public short Year { get; set; }
    
    public string Set { get; set; }
    
    public float EngineCapacity { get; set; }
    
    public ushort HorsePower { get; set; }
    
    public Guid FuelTypeId { get; set; }
    
    public Guid TransmissionId { get; set; }
    
    public Guid DriveTrainId { get; set; }
    
    public Guid CarColorId { get; set; }
    
    public string Description { get; set; }
    
    public float Price { get; set; }
    
    public List<Guid>? FeatureIds { get; set; }
}