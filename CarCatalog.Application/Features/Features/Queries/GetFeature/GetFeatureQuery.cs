using MediatR;

namespace CarCatalog.Application.Features.Features.Queries.GetFeature;

public class GetFeatureQuery : IRequest<GetFeatureQueryViewModel>
{
    public Guid Id { get; set; }
}