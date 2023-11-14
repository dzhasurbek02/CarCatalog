using CarCatalog.Application.Features.CarModels.Commands.CreateCarModel;
using CarCatalog.Application.Features.CarModels.Commands.DeleteCarModel;
using CarCatalog.Application.Features.CarModels.Commands.UpdateCarModel;
using CarCatalog.Application.Features.CarModels.Queries.GetAllCarModels;
using CarCatalog.Application.Features.CarModels.Queries.GetCarModel;
using CarCatalog.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalog.WebApi.Controllers;

[Route("api/carModels")]
[ApiController]
public class CarModelController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarModelController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("create")]
    public async Task<ActionResult> CreateCarModel([FromBody] CreateCarModelCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<CarModel>> GetCarModel([FromRoute] Guid id)
    {
        return Ok(await _mediator.Send(new GetCarModelQuery { Id = id }));
    }
    
    [HttpGet(Name = "CarModelList")]
    public async Task<IActionResult> GetAllCarModels(int pageNumber, int pageSize)
    {
        var query = new GetAllCarModelsQuery(pageNumber, pageSize);
        var carModels = await _mediator.Send(query);
        
        return Ok(carModels);
    }

    [HttpPost("update")]
    public async Task<IActionResult> UpdateCarModel([FromBody] UpdateCarModelCommand command)
    {
        await _mediator.Send(command);
        
        return NoContent();
    }
    
    [HttpPost("delete/{id}")]
    public async Task<IActionResult> DeleteUser([FromRoute]Guid id)
    {
        await _mediator.Send(new DeleteCarModelCommand { Id = id });
        
        return Ok();
    }
}