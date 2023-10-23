using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Users.Commands.CreateUser;

public class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserCommand, User>();
    }
}