using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Users.Queries.GetAllUsers;

public class GetAllUsersMapper : Profile
{
    public GetAllUsersMapper()
    {
        CreateMap<User, GetAllUsersViewModel>();

    }
}