using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.Features.Queries.GetFeature;

public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, GetFeatureQueryViewModel>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetFeatureQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetFeatureQueryViewModel> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
    {
        return await _context.Features
            .AsNoTracking()
            .Where(f => f.Id == request.Id)
            .ProjectTo<GetFeatureQueryViewModel>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(cancellationToken)
                ?? throw new NotFoundException("Фича не найдена!");
    }
}