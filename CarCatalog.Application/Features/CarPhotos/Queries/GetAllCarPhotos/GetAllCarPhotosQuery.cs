using CarCatalog.Application.Common.Pagination;
using MediatR;

namespace CarCatalog.Application.Features.CarPhotos.Queries.GetAllCarPhotos;

public class GetAllCarPhotosQuery : IRequest<PaginatedList<GetAllCarPhotosQueryViewModel>>
{
    public int PageNumber { get; }
    public int PageSize { get; }

    public GetAllCarPhotosQuery(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
}