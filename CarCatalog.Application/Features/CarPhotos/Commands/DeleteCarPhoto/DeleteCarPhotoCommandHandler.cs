using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.CarPhotos.Commands.DeleteCarPhoto;

public class DeleteCarPhotoCommandHandler : IRequestHandler<DeleteCarPhotoCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteCarPhotoCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<Unit> Handle(DeleteCarPhotoCommand request, CancellationToken cancellationToken)
    {
        var photo = await _context.Photos
            .FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken)
                ?? throw new NotFoundException("Фото не найдено!");

        _context.Photos.Remove(photo);
        await _context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}