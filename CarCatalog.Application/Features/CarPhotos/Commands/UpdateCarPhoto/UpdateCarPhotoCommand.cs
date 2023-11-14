using MediatR;

namespace CarCatalog.Application.Features.CarPhotos.Commands.UpdateCarPhoto;

public class UpdateCarPhotoCommand : IRequest
{
    public Guid Id { get; set; }
    
    public Guid CarId { get; set; }

    public string PhotoURL { get; set; }
}