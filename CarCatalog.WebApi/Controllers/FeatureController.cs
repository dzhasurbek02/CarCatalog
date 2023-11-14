using CarCatalog.Application.Features.Features.Commands.CreateFeature;
using CarCatalog.Application.Features.Features.Commands.DeleteFeature;
using CarCatalog.Application.Features.Features.Commands.UpdateFeature;
using CarCatalog.Application.Features.Features.Queries.GetAllFeatures;
using CarCatalog.Application.Features.Features.Queries.GetFeature;
using CarCatalog.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalog.WebApi.Controllers;

[Route("api/features")]
[ApiController]
public class FeatureController : ControllerBase
{
    private readonly IMediator _mediator;

    public FeatureController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("create")]
    public async Task<ActionResult> CreateFeature([FromBody] CreateFeatureCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Feature>> GetFeature([FromRoute] Guid id)
    {
        return Ok(await _mediator.Send(new GetFeatureQuery() { Id = id }));
    }
    
    [HttpGet(Name = "FeaturesList")]
    public async Task<IActionResult> GetAllFeatures(int pageNumber, int pageSize)
    {
        var query = new GetAllFeaturesQuery(pageNumber, pageSize);
        var features = await _mediator.Send(query);
        
        return Ok(features);
    }

    [HttpPost("update")]
    public async Task<IActionResult> UpdateFeature([FromBody] UpdateFeatureCommand command)
    {
        await _mediator.Send(command);
        
        return NoContent();
    }
    
    [HttpPost("delete/{id}")]
    public async Task<IActionResult> DeleteFeature([FromRoute]Guid id)
    {
        await _mediator.Send(new DeleteFeatureCommand() { Id = id });
        
        return Ok();
    }
}