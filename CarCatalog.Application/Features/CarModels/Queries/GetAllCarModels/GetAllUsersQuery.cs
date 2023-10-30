using CarCatalog.Application.Common.Pagination;
using CarCatalog.Application.Features.CarModels.Queries.GetCarModel;
using MediatR;

namespace CarCatalog.Application.Features.CarModels.Queries.GetAllCarModels;

public class GetAllUsersQuery : IRequest<PaginatedList<GetCarModelQueryViewModel>>
{
    public int PageNumber { get; }
    public int PageSize { get; }

    public GetAllUsersQuery(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}