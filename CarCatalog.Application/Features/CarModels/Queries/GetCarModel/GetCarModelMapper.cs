using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.CarModels.Queries.GetCarModel;

public class GetCarModelMapper : Profile
{
    public GetCarModelMapper()
    {
        CreateMap<CarModel, GetCarModelQueryViewModel>()
            .ForMember(mvm => mvm.BrandName,
                t => t.MapFrom(src => $"{src.Brand.Name}"));
    }
}