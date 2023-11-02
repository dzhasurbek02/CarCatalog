using AutoMapper;
using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.CarPhotos.Commands.UpdateCarPhoto;

public class UpdateCarPhotoCommandHandler : IRequestHandler<UpdateCarPhotoCommand>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateCarPhotoCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<Unit> Handle(UpdateCarPhotoCommand request, CancellationToken cancellationToken)
    {
        var photo = await _context.Photos
            .FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken)
                ?? throw new NotFoundException("Фото не найдено!");

        _mapper.Map(request, photo);
        await _context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}