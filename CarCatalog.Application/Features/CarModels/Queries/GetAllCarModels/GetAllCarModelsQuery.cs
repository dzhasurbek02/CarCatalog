using CarCatalog.Application.Common.Pagination;
using MediatR;

namespace CarCatalog.Application.Features.CarModels.Queries.GetAllCarModels;

public class GetAllCarModelsQuery : IRequest<PaginatedList<GetAllCarModelsViewModel>>
{
    public int PageNumber { get; }
    public int PageSize { get; }

    public GetAllCarModelsQuery(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}