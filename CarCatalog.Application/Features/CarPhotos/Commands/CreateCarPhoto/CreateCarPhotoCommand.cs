using MediatR;

namespace CarCatalog.Application.Features.CarPhotos.Commands.CreateCarPhoto;

public class CreateCarPhotoCommand : IRequest<Guid>
{
    public Guid CarId { get; set; }

    public string PhotoURL { get; set; }
}