using CarCatalog.Domain.Entities;
using MediatR;

namespace CarCatalog.Application.Users.Queries.GetUser;

public class GetUserQuery : IRequest<UserQueryViewModel>
{
    public Guid Id { get; set; }
}