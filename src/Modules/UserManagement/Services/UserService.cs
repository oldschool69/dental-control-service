using Microsoft.EntityFrameworkCore;
using UserManagement.Data;
using UserManagement.DTOs;
using UserManagement.Interfaces;

namespace UserManagement.Services;

public class UserService(UserDbContext context) : IUserService
{
    public async Task<IEnumerable<UserDto>> GetAll()
    {
        var users = await context.Users.ToListAsync();
        return users.Select(u => new UserDto(u.Id, u.UserName, u.Role, u.Email));
    }

    public async Task<UserDto?> GetById(string id) =>
        await context.Users
            .Where(u => u.Id == id)
            .Select(u => new UserDto(u.Id, u.UserName, u.Role, u.Email))
            .FirstOrDefaultAsync();
}
