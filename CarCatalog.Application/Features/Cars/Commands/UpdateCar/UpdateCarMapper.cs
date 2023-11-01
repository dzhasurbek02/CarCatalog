using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.Cars.Commands.UpdateCar;

public class UpdateCarMapper : Profile
{
    public UpdateCarMapper()
    {
        CreateMap<UpdateCarCommand, Car>();
    }
}