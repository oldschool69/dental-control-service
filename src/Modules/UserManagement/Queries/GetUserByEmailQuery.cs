using MediatR;
using UserManagement.DTOs;

namespace UserManagement.Queries
{
    public record GetUserByEmailQuery(string Email) : IRequest<UserDto>;
    
}
