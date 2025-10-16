using UserManagement.DTOs;

namespace UserManagement.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetAll();
    Task<UserDto?> GetById(string id);
}
