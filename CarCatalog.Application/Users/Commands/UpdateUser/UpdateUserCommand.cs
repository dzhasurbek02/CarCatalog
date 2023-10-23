using MediatR;

namespace CarCatalog.Application.Users.Commands.UpdateUser;

public class UpdateUserCommand : IRequest
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
     
    public string Email { get; set; }
     
    public string Password { get; set; }
}