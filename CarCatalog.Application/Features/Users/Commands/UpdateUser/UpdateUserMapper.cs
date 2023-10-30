using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserMapper : Profile
{
    public UpdateUserMapper()
    {
        CreateMap<UpdateUserCommand, User>();
    }
}