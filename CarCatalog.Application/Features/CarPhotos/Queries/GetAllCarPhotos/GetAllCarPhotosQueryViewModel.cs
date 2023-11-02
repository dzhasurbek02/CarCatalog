namespace CarCatalog.Application.Features.CarPhotos.Queries.GetAllCarPhotos;

public class GetAllCarPhotosQueryViewModel
{
    public Guid Id { get; set; }
    
    public Guid CarId { get; set; }
    
    public string PhotoURL { get; set; }
}