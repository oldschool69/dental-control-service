using UserManagement.DTOs;
using UserManagement.Interfaces;

namespace UserManagement.Services;

public class UserService : IUserService
{
    private readonly List<UserDto> _users = new()
    {
        new UserDto(1, "admin", "Administrator", "admin@example.com"),
        new UserDto(2, "john.doe", "Standard User", "john.doe@example.com")
    };

    public IEnumerable<UserDto> GetAll() => _users;

    public UserDto? GetById(int id) =>
        _users.FirstOrDefault(u => u.Id == id);
}
