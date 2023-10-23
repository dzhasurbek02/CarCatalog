using CarCatalog.Application.Users.Commands.CreateUser;
using CarCatalog.Application.Users.Commands.DeleteUser;
using CarCatalog.Application.Users.Commands.UpdateUser;
using CarCatalog.Application.Users.Queries.GetAllUsers;
using CarCatalog.Application.Users.Queries.GetUser;
using CarCatalog.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarCatalog.WebApi.Controllers;

[Route("api/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("create")]
    public async Task<ActionResult> CreateUser([FromBody] CreateUserCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser([FromRoute] Guid id)
    {
        return Ok(await _mediator.Send(new GetUserQuery { Id = id }));
    }
    
    [HttpGet(Name = "UserList")]
    public async Task<IActionResult> GetAllUsers(int pageNumber, int pageSize)
    {
        var query = new GetAllUsersQuery(pageNumber, pageSize);
        var users = await _mediator.Send(query);
        
        return Ok(users);
    }

    [HttpPost("update")]
    public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command)
    {
        await _mediator.Send(command);
        
        return NoContent();
    }
    
    [HttpPost("delete/{id}")]
    public async Task<IActionResult> DeleteUser([FromRoute]Guid id)
    {
        await _mediator.Send(new DeleteUserCommand { Id = id });
        
        return Ok();
    }
}