using CarCatalog.Application.Common.Pagination;
using MediatR;

namespace CarCatalog.Application.Features.Features.Queries.GetAllFeatures;

public class GetAllFeaturesQuery : IRequest<PaginatedList<GetAllFeaturesQueryViewModel>>
{
    public int PageNumber { get; }
    public int PageSize { get; }

    public GetAllFeaturesQuery(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}