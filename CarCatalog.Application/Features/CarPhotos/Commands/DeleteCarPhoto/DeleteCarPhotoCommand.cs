using MediatR;

namespace CarCatalog.Application.Features.CarPhotos.Commands.DeleteCarPhoto;

public class DeleteCarPhotoCommand : IRequest
{
    public Guid Id { get; set; }
}