using Microsoft.AspNetCore.Mvc;
using UserManagement.Interfaces;

namespace DentalControl.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public IActionResult GetAllUsers() => Ok(_userService.GetAll());

    [HttpGet("{id:int}")]
    public IActionResult GetUserById(int id)
    {
        var user = _userService.GetById(id);
        return user is null ? NotFound() : Ok(user);
    }
}
