using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.CarModels.Commands.CreateCarModel;

public class CreateCarModelMapper : Profile
{
    public CreateCarModelMapper()
    {
        CreateMap<CreateCarModelCommand, CarModel>();
    }
}