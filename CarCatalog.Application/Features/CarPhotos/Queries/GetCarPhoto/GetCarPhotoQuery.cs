using MediatR;

namespace CarCatalog.Application.Features.CarPhotos.Queries.GetCarPhoto;

public class GetCarPhotoQuery : IRequest<GetCarPhotoQueryViewModel>
{
    public Guid Id { get; set; }
}