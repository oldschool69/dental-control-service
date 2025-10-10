using Authentication.DTOs;

namespace Authentication.Interfaces;

public interface IAuthService
{
    Task<bool> LoginAsync(string email);
}
