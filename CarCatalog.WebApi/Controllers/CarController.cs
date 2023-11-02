using CarCatalog.Application.Features.Cars.Commands.CreateCar;
using CarCatalog.Application.Features.Cars.Commands.DeleteCar;
using CarCatalog.Application.Features.Cars.Commands.UpdateCar;
using CarCatalog.Application.Features.Cars.Queries.GetAllCars;
using CarCatalog.Application.Features.Cars.Queries.GetCar;
using CarCatalog.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalog.WebApi.Controllers;

[Route("api/cars")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("create")]
    public async Task<ActionResult> CreateCar([FromBody] CreateCarCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Car>> GetCar([FromRoute] Guid id)
    {
        return Ok(await _mediator.Send(new GetCarQuery() { Id = id }));
    }
    
    [HttpGet(Name = "CarsList")]
    public async Task<IActionResult> GetAllCars(int pageNumber, int pageSize)
    {
        var query = new GetAllCarsQuery(pageNumber, pageSize);
        var cars = await _mediator.Send(query);
        
        return Ok(cars);
    }

    [HttpPost("update")]
    public async Task<IActionResult> UpdateCar([FromBody] UpdateCarCommand command)
    {
        await _mediator.Send(command);
        
        return NoContent();
    }
    
    [HttpPost("delete/{id}")]
    public async Task<IActionResult> DeleteCar([FromRoute]Guid id)
    {
        await _mediator.Send(new DeleteCarCommand() { Id = id });
        
        return Ok();
    }
}