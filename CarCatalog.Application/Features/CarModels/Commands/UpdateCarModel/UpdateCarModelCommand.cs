using MediatR;

namespace CarCatalog.Application.Features.CarModels.Commands.UpdateCarModel;

public class UpdateCarModelCommand : IRequest
{
    public Guid Id { get; set; }
    
    public Guid BrandId { get; set; }
    
    public string Name { get; set; }
}