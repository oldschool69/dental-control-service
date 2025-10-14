using System;

namespace Authentication.Entities;

public class Login
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string UserName { get; set; }
    public required string PasswordHash { get; set; }
}
