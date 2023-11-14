namespace CarCatalog.Application.Features.Users.Queries.GetUser;

public class UserQueryViewModel
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public DateTime? LastLoginDate { get; set; }
}