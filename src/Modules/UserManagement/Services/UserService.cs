using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UserManagement.Data;
using UserManagement.DTOs;
using UserManagement.Interfaces;

namespace UserManagement.Services;

public class UserService(UserDbContext context, IMapper mapper) : IUserService
{
    public async Task<IEnumerable<UserDto>> GetAll()
    {
        var users = await context.Users.ToListAsync();
        return mapper.Map<IEnumerable<UserDto>>(users);
    }

    public async Task<UserDto?> GetById(string id)
    {
        var user = await context.Users.FindAsync(id);
        return user is null ? null : mapper.Map<UserDto>(user);
    }
}
