using AutoMapper;
using CarCatalog.Domain.Entities;

namespace CarCatalog.Application.Features.Users.Queries.GetUser;

public class GetUserMapper : Profile
{
    public GetUserMapper()
    {
        CreateMap<User, UserQueryViewModel>();
    }
}