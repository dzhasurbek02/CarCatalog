using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.Features.Commands.DeleteFeature;

public class DeleteFeatureCommandHandler : IRequestHandler<DeleteFeatureCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteFeatureCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteFeatureCommand request, CancellationToken cancellationToken)
    {
        var feature = await _context.Features
            .FirstOrDefaultAsync(f => f.Id == request.Id, cancellationToken)
                ?? throw new NotFoundException("Фича не найдена!");

        _context.Features.Remove(feature);
        await _context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}