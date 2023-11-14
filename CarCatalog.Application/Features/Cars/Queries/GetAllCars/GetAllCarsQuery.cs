using CarCatalog.Application.Common.Pagination;
using MediatR;

namespace CarCatalog.Application.Features.Cars.Queries.GetAllCars;

public class GetAllCarsQuery : IRequest<PaginatedList<GetAllCarsQueryViewModel>>
{
    public int PageNumber { get; }
    public int PageSize { get; }

    public GetAllCarsQuery(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}