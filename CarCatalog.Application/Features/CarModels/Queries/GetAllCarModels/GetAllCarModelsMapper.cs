using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.CarModels.Queries.GetAllCarModels;

public class GetAllCarModelsMapper : Profile
{
    public GetAllCarModelsMapper()
    {
        CreateMap<CarModel, GetAllCarModelsViewModel>()
            .ForMember(mvm => mvm.BrandName,
                t => t.MapFrom(src => $"{src.Brand.Name}"));
    }
}