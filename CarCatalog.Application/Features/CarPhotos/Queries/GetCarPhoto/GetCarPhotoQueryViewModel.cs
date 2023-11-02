namespace CarCatalog.Application.Features.CarPhotos.Queries.GetCarPhoto;

public class GetCarPhotoQueryViewModel
{
    public Guid Id { get; set; }
    
    public Guid CarId { get; set; }
    
    public string PhotoURL { get; set; }
}