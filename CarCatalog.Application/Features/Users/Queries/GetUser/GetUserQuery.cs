using MediatR;

namespace CarCatalog.Application.Features.Users.Queries.GetUser;

public class GetUserQuery : IRequest<UserQueryViewModel>
{
    public Guid Id { get; set; }
}