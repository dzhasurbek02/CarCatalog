using AutoMapper;
using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Domain.Entities;
using MediatR;

namespace CarCatalog.Application.Features.Cars.Commands.CreateCar;

public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Guid>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateCarCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateCarCommand request, CancellationToken cancellationToken)
    {
        var car = _mapper.Map<Car>(request);

        _context.Cars.Add(car);
        
        var carFeatures = request.FeatureIds.Select(x => new CarFeature
            {
                CarId = car.Id,
                FeatureId = x
            })
            .ToList();

        _context.CarFeatures.AddRange(carFeatures);
        
        await _context.SaveChangesAsync(cancellationToken);

        return car.Id;
    }
}