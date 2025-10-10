using UserManagement.DTOs;

namespace UserManagement.Interfaces;

public interface IUserService
{
    IEnumerable<UserDto> GetAll();
    UserDto? GetById(int id);
}
