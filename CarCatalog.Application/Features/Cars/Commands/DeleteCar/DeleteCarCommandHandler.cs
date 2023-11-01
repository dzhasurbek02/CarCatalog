using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.Cars.Commands.DeleteCar;

public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteCarCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
    {
        var car = await _context.Cars
            .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken)
                ?? throw new NotFoundException("Автомобиль не найден!");

        _context.Cars.Remove(car);
        await _context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}