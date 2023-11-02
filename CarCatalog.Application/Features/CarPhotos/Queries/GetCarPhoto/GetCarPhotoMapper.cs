using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.CarPhotos.Queries.GetCarPhoto;

public class GetCarPhotoMapper : Profile
{
    public GetCarPhotoMapper()
    {
        CreateMap<CarPhoto, GetCarPhotoQueryViewModel>();
    }
}