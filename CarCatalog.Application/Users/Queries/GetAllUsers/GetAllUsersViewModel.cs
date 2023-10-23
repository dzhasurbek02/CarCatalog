namespace CarCatalog.Application.Users.Queries.GetAllUsers;

public class GetAllUsersViewModel
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public DateTime? LastLoginDate { get; set; }
}