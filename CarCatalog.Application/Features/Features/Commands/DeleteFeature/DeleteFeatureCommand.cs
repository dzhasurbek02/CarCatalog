using MediatR;

namespace CarCatalog.Application.Features.Features.Commands.DeleteFeature;

public class DeleteFeatureCommand : IRequest
{
    public Guid Id { get; set; }
}