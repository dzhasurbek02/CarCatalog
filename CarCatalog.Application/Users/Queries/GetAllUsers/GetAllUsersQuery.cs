using CarCatalog.Application.Common.Pagination;
using MediatR;

namespace CarCatalog.Application.Users.Queries.GetAllUsers;

public class GetAllUsersQuery : IRequest<PaginatedList<GetAllUsersViewModel>>
{
    public int PageNumber { get; }
    public int PageSize { get; }

    public GetAllUsersQuery(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}