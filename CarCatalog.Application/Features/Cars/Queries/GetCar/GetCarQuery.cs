using MediatR;

namespace CarCatalog.Application.Features.Cars.Queries.GetCar;

public class GetCarQuery : IRequest<GetCarQueryViewModel>
{
    public Guid Id { get; set; }
}