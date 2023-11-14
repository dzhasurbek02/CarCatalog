using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Application.Common.Pagination;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.CarModels.Queries.GetAllCarModels;

public class GetAllCarModelsQueryHandler : IRequestHandler<GetAllCarModelsQuery, PaginatedList<GetAllCarModelsViewModel>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllCarModelsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<GetAllCarModelsViewModel>> Handle(GetAllCarModelsQuery request, CancellationToken cancellationToken)
    {
        var query = _context.CarModels
            .AsNoTracking()
            .ProjectTo<GetAllCarModelsViewModel>(_mapper.ConfigurationProvider);

        return await PaginatedList<GetAllCarModelsViewModel>.CreateAsync(query, request.PageNumber, request.PageSize);
    }
}