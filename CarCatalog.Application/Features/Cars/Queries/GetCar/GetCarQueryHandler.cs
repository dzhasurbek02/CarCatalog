using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.Cars.Queries.GetCar;

public class GetCarQueryHandler : IRequestHandler<GetCarQuery, GetCarQueryViewModel>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetCarQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetCarQueryViewModel> Handle(GetCarQuery request, CancellationToken cancellationToken)
    {
        return await _context.Cars
            .AsNoTracking()
            .Where(c => c.Id == request.Id)
            .ProjectTo<GetCarQueryViewModel>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(cancellationToken)
                ?? throw new NotFoundException("Автомобиль не найден!");
    }
}