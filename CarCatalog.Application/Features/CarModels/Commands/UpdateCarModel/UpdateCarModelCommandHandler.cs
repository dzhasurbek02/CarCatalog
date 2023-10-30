using AutoMapper;
using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.CarModels.Commands.UpdateCarModel;

public class UpdateCarModelCommandHandler : IRequestHandler<UpdateCarModelCommand>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateCarModelCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateCarModelCommand request, CancellationToken cancellationToken)
    {
        var carModel = await _context.CarModels
            .FirstOrDefaultAsync(cm => cm.Id == request.Id, cancellationToken)
                ?? throw new NotFoundException("Модель не найдена!");

        _mapper.Map(request, carModel);

        await _context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}