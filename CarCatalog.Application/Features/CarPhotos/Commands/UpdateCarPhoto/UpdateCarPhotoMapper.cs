using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.CarPhotos.Commands.UpdateCarPhoto;

public class UpdateCarPhotoMapper : Profile
{
    public UpdateCarPhotoMapper()
    {
        CreateMap<UpdateCarPhotoCommand, CarPhoto>();
    }
}