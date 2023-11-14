using AutoMapper;
using CarCatalog.Application.Common.Interfaces;
using CarCatalog.Domain.Entities;
using MediatR;

namespace CarCatalog.Application.Features.CarPhotos.Commands.CreateCarPhoto;

public class CreateCarPhotoCommandHandler : IRequestHandler<CreateCarPhotoCommand, Guid>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateCarPhotoCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<Guid> Handle(CreateCarPhotoCommand request, CancellationToken cancellationToken)
    {
        var photo = _mapper.Map<CarPhoto>(request);

        _context.Photos.Add(photo);
        await _context.SaveChangesAsync(cancellationToken);

        return photo.Id;
    }
}