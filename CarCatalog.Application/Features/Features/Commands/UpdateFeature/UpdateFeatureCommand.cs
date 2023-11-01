using MediatR;

namespace CarCatalog.Application.Features.Features.Commands.UpdateFeature;

public class UpdateFeatureCommand : IRequest
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
}