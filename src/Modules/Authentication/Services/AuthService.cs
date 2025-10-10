using Authentication.DTOs;
using Authentication.Interfaces;

namespace Authentication.Services;

public class AuthService : IAuthService
{
    public LoginResponseDto? Authenticate(LoginRequestDto request)
    {
        if (request.Username == "admin" && request.Password == "1234")
        {
            return new LoginResponseDto("mock-jwt-token", request.Username);
        }

        return null;
    }
}
