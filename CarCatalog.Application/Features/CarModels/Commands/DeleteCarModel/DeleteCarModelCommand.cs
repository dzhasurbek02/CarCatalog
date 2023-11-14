using MediatR;

namespace CarCatalog.Application.Features.CarModels.Commands.DeleteCarModel;

public class DeleteCarModelCommand : IRequest
{
    public Guid Id { get; set; }
}