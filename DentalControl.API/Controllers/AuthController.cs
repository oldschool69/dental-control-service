using Authentication.DTOs;
using Authentication.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DentalControl.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequestDto request)
    {
        var result = _authService.Authenticate(request);
        return result is null ? Unauthorized(new { Message = "Invalid credentials" }) : Ok(result);
    }
}
