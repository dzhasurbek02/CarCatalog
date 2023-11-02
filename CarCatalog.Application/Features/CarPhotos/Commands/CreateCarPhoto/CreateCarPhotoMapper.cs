using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.CarPhotos.Commands.CreateCarPhoto;

public class CreateCarPhotoMapper : Profile
{
    public CreateCarPhotoMapper()
    {
        CreateMap<CreateCarPhotoCommand, CarPhoto>();
    }
}