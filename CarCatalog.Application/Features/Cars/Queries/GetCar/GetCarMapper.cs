using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.Cars.Queries.GetCar;

public class GetCarMapper : Profile
{
    public GetCarMapper()
    {
        CreateMap<Car, GetCarQueryViewModel>()
            .ForMember(c => c.BrandName,
                t => t.MapFrom(src => $"{src.Brand.Name}"))
            .ForMember(c => c.CarModelName,
                t => t.MapFrom(src => $"{src.CarModel.Name}"))
            .ForMember(c => c.BodyStyleName,
                t=> t.MapFrom(src=>$"{src.BodyStyle.Name}"))
            .ForMember(c=>c.FuelTypeName,
                t=>t.MapFrom(src=>$"{src.FuelType.Name}"))
            .ForMember(c=>c.TransmissionName,
                t=>t.MapFrom(src=>$"{src.Transmission.Name}"))
            .ForMember(c=>c.DriveTrainName,
                t=>t.MapFrom(src=>$"{src.DriveTrain.Name}"))
            .ForMember(c=>c.CarColorName,
                t=>t.MapFrom(src=>$"{src.CarColor.Name}"))
            .ForMember(c => c.CarPhotos,
                t => t.MapFrom(p => p.CarPhotos.SelectMany(cp => cp.PhotoURL)))
            .ForMember(c => c.Features,
                t => t.MapFrom(f => f.CarFeatures.Select(p => p.Feature)));
    }
}