using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Application.Common.Pagination;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.CarPhotos.Queries.GetAllCarPhotos;

public class GetAllCarPhotosQueryHandler : IRequestHandler<GetAllCarPhotosQuery, PaginatedList<GetAllCarPhotosQueryViewModel>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllCarPhotosQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<PaginatedList<GetAllCarPhotosQueryViewModel>> Handle(GetAllCarPhotosQuery request, CancellationToken cancellationToken)
    {
        var query = _context.Photos
            .AsNoTracking()
            .ProjectTo<GetAllCarPhotosQueryViewModel>(_mapper.ConfigurationProvider);
        
        return await PaginatedList<GetAllCarPhotosQueryViewModel>.CreateAsync(query, request.PageNumber, request.PageSize);
    }
}