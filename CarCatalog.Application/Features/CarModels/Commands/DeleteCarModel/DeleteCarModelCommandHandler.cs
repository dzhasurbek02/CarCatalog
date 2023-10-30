using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.CarModels.Commands.DeleteCarModel;

public class DeleteCarModelCommandHandler : IRequestHandler<DeleteCarModelCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteCarModelCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteCarModelCommand request, CancellationToken cancellationToken)
    {
        var carModel = await _context.CarModels
            .FirstOrDefaultAsync(cm => cm.Id == request.Id, cancellationToken)
                ?? throw new NotFoundException("Модель не найдена!");

        _context.CarModels.Remove(carModel);
        await _context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}