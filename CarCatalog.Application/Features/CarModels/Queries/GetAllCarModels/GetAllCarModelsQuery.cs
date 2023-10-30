using CarCatalog.Application.Common.Pagination;
using CarCatalog.Application.Features.CarModels.Queries.GetCarModel;
using MediatR;

namespace CarCatalog.Application.Features.CarModels.Queries.GetAllCarModels;

public class GetAllCarModelsQuery : IRequest<PaginatedList<GetCarModelQueryViewModel>>
{
    public int PageNumber { get; }
    public int PageSize { get; }

    public GetAllCarModelsQuery(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}