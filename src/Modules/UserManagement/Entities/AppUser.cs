using System;

namespace UserManagement.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string UserName { get; set; }
    public required string Role { get; set; }
    public required string Email { get; set; }   

}
