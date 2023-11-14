using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Application.Common.Pagination;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.Features.Queries.GetAllFeatures;

public class GetAllFeaturesQueryHandler : IRequestHandler<GetAllFeaturesQuery, PaginatedList<GetAllFeaturesQueryViewModel>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllFeaturesQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<PaginatedList<GetAllFeaturesQueryViewModel>> Handle(GetAllFeaturesQuery request, CancellationToken cancellationToken)
    {
        var query = _context.Features
            .AsNoTracking()
            .ProjectTo<GetAllFeaturesQueryViewModel>(_mapper.ConfigurationProvider);

        return await PaginatedList<GetAllFeaturesQueryViewModel>.CreateAsync(query, request.PageNumber, request.PageSize);
    }
}