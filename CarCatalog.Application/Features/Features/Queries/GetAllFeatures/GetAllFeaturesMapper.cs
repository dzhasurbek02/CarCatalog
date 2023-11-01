using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.Features.Queries.GetAllFeatures;

public class GetAllFeaturesMapper : Profile
{
    public GetAllFeaturesMapper()
    {
        CreateMap<Feature, GetAllFeaturesQueryViewModel>();
    }
}