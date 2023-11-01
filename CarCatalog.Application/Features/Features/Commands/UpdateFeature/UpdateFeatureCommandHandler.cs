using AutoMapper;
using CarCatalog.Application.Common.Exceptions;
using CarCatalog.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarCatalog.Application.Features.Features.Commands.UpdateFeature;

public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommand>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateFeatureCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateFeatureCommand request, CancellationToken cancellationToken)
    {
        var feature = await _context.Features
            .FirstOrDefaultAsync(f => f.Id == request.Id, cancellationToken)
                ?? throw new NotFoundException("Фича не найдена!");

        _mapper.Map(request, feature);
        await _context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}