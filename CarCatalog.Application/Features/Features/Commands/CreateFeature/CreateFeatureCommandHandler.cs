using AutoMapper;
using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Domain.Entities;
using MediatR;

namespace CarCatalog.Application.Features.Features.Commands.CreateFeature;

public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommand, Guid>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateFeatureCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
    {
        var feature = _mapper.Map<Feature>(request);

        _context.Features.Add(feature);
        await _context.SaveChangesAsync(cancellationToken);
        
        return feature.Id;
    }
}