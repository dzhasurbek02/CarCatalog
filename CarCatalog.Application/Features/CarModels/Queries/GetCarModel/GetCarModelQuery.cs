using MediatR;

namespace CarCatalog.Application.Features.CarModels.Queries.GetCarModel;

public class GetCarModelQuery : IRequest<GetCarModelQueryViewModel>
{
    public Guid Id { get; set; }
}