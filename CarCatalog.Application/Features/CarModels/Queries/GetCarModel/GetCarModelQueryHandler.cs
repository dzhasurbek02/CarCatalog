using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.CarModels.Queries.GetCarModel;

public class GetCarModelQueryHandler : IRequestHandler<GetCarModelQuery, GetCarModelQueryViewModel>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetCarModelQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetCarModelQueryViewModel> Handle(GetCarModelQuery request, CancellationToken cancellationToken)
    {
        return await _context.CarModels
            .AsNoTracking()
            .Where(cm => cm.Id == request.Id)
            .ProjectTo<GetCarModelQueryViewModel>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(cancellationToken)
                ?? throw new NotFoundException("Модель не найдена!");
    }
}