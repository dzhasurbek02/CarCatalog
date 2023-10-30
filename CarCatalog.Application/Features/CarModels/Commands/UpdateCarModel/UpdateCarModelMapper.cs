using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.CarModels.Commands.UpdateCarModel;

public class UpdateCarModelMapper : Profile
{
    public UpdateCarModelMapper()
    {
        CreateMap<UpdateCarModelCommand, CarModel>();
    }
}