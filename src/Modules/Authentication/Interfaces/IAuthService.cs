using Authentication.DTOs;

namespace Authentication.Interfaces;

public interface IAuthService
{
    LoginResponseDto? Authenticate(LoginRequestDto request);
}
