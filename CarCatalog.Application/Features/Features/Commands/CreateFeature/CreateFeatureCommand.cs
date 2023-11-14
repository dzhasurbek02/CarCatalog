using MediatR;

namespace CarCatalog.Application.Features.Features.Commands.CreateFeature;

public class CreateFeatureCommand : IRequest<Guid>
{
    public string Name { get; set; }
    
    public DateTime CreatedDateTime { get; set; }
}