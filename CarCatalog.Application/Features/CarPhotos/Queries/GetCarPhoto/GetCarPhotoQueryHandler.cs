using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.CarPhotos.Queries.GetCarPhoto;

public class GetCarPhotoQueryHandler : IRequestHandler<GetCarPhotoQuery, GetCarPhotoQueryViewModel>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetCarPhotoQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<GetCarPhotoQueryViewModel> Handle(GetCarPhotoQuery request, CancellationToken cancellationToken)
    {
        return await _context.Photos
            .AsNoTracking()
            .Where(p => p.Id == request.Id)
            .ProjectTo<GetCarPhotoQueryViewModel>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(cancellationToken)
                ?? throw new NotFoundException("Фото не найдено!");
    }
}