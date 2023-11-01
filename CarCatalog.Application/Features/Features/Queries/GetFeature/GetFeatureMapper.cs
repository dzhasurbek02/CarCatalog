using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.Features.Queries.GetFeature;

public class GetFeatureMapper : Profile
{
    public GetFeatureMapper()
    {
        CreateMap<Feature, GetFeatureQueryViewModel>();
    }
}