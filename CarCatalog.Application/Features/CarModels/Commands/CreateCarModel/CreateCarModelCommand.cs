using MediatR;

namespace CarCatalog.Application.Features.CarModels.Commands.CreateCarModel;

public class CreateCarModelCommand : IRequest<Guid>
{
    public Guid BrandId { get; set; }
    
    public string Name { get; set; }
}