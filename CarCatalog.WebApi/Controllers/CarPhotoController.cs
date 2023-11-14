using CarCatalog.Application.Features.CarPhotos.Commands.CreateCarPhoto;
using CarCatalog.Application.Features.CarPhotos.Commands.DeleteCarPhoto;
using CarCatalog.Application.Features.CarPhotos.Commands.UpdateCarPhoto;
using CarCatalog.Application.Features.CarPhotos.Queries.GetAllCarPhotos;
using CarCatalog.Application.Features.CarPhotos.Queries.GetCarPhoto;
using CarCatalog.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalog.WebApi.Controllers;

[Route("api/carPhotos")]
[ApiController]
public class CarPhotoController : ControllerBase
{
    private readonly IMediator _mediator;

    public CarPhotoController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("create")]
    public async Task<ActionResult> CreateCarPhoto([FromBody] CreateCarPhotoCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CarPhoto>> GetCarPhoto([FromRoute] Guid id)
    {
        return Ok(await _mediator.Send(new GetCarPhotoQuery() { Id = id }));
    }
    
    [HttpGet(Name = "CarPhotosList")]
    public async Task<IActionResult> GetAllCarPhotos(int pageNumber, int pageSize)
    {
        var query = new GetAllCarPhotosQuery(pageNumber, pageSize);
        var carPhotos = await _mediator.Send(query);
        
        return Ok(carPhotos);
    }

    [HttpPost("update")]
    public async Task<IActionResult> UpdateCarPhoto([FromBody] UpdateCarPhotoCommand command)
    {
        await _mediator.Send(command);
        
        return NoContent();
    }
    
    [HttpPost("delete/{id}")]
    public async Task<IActionResult> DeleteCarPhoto([FromRoute]Guid id)
    {
        await _mediator.Send(new DeleteCarPhotoCommand() { Id = id });
        
        return Ok();
    }
}