using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.Features.Commands.UpdateFeature;

public class UpdateFeatureMapper : Profile
{
    public UpdateFeatureMapper()
    {
        CreateMap<UpdateFeatureCommand, Feature>();
    }
}