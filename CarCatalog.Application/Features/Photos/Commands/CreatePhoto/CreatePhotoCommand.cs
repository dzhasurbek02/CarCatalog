using MediatR;

namespace CarCatalog.Application.Features.Photos.Commands.CreatePhoto;

public class CreatePhotoCommand : IRequest<Guid>
{
    public Guid CarId { get; set; }

    public string PhotoURL { get; set; }
}