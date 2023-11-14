using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.Cars.Commands.CreateCar;

public class CreateCarMapper : Profile
{
    public CreateCarMapper()
    {
        CreateMap<CreateCarCommand, Car>();
    }
}