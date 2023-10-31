using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.Features.Commands.CreateFeature;

public class CreateFeatureMapper : Profile
{
    public CreateFeatureMapper()
    {
        CreateMap<CreateFeatureCommand, Feature>();
    }
}