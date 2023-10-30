using AutoMapper;
using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Domain.Entities;
using MediatR;

namespace CarCatalog.Application.Features.CarModels.Commands.CreateCarModel;

public class CreateCarModelCommandHandler : IRequestHandler<CreateCarModelCommand, Guid>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateCarModelCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateCarModelCommand request, CancellationToken cancellationToken)
    {
        var carModel = _mapper.Map<CarModel>(request);

        _context.CarModels.Add(carModel);
        await _context.SaveChangesAsync(cancellationToken);
        
        return carModel.Id;
    }
}