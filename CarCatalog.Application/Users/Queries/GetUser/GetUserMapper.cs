using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Users.Queries.GetUser;

public class GetUserMapper : Profile
{
    public GetUserMapper()
    {
        CreateMap<User, UserQueryViewModel>();
    }
}