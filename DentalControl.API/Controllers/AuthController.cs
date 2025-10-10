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
    public async Task<IActionResult> Login([FromQuery] string email)
    {
        var success = await _authService.LoginAsync(email);
        return success
            ? Ok(new { message = "Login successful!" })
            : NotFound(new { message = "User not found." });
    }
}
