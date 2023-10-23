using CarCatalog.Domain.Common;

namespace CarCatalog.Domain.Entities;

public class User : BaseEntity
{   
    public string Name { get; set; }
    
    public string Email { get; set; }
    
    public string Password { get; set; }
    
    public DateTime? LastLoginDate { get; set; }
}