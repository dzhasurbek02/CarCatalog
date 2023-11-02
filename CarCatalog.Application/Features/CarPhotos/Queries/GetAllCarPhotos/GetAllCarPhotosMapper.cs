using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.CarPhotos.Queries.GetAllCarPhotos;

public class GetAllCarPhotosMapper : Profile
{
    public GetAllCarPhotosMapper()
    {
        CreateMap<CarPhoto, GetAllCarPhotosQueryViewModel>();
    }
}