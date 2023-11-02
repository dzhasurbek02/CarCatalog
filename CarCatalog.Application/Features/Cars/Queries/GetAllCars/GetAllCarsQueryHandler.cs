using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Application.Common.Pagination;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.Cars.Queries.GetAllCars;

public class GetAllCarsQueryHandler : IRequestHandler<GetAllCarsQuery, PaginatedList<GetAllCarsQueryViewModel>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetAllCarsQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<GetAllCarsQueryViewModel>> Handle(GetAllCarsQuery request, CancellationToken cancellationToken)
    {
        var query = _context.Cars
            .AsNoTracking()
            .ProjectTo<GetAllCarsQueryViewModel>(_mapper.ConfigurationProvider);

        return await PaginatedList<GetAllCarsQueryViewModel>.CreateAsync(query, request.PageNumber, request.PageSize);
    }
}