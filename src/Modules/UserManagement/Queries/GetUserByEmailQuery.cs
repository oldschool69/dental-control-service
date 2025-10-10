using MediatR;

namespace UserManagement.Queries
{
    public record GetUserByEmailQuery(string Email) : IRequest<UserDto>;

    public record UserDto(Guid Id, string Email);
}
