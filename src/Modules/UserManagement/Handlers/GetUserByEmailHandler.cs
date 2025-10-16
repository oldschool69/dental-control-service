using MediatR;
using UserManagement.DTOs;
using UserManagement.Queries;

namespace UserManagement.Handlers
{
    public class GetUserByEmailHandler : IRequestHandler<GetUserByEmailQuery, UserDto>
    {
        // This could be replaced by a real database in the future
        private static readonly List<UserDto> MockUsers =
        [
            new("1", "admin", "Administrator", "admin@example.com"),
            new("2", "john.doe", "Standard User", "john.doe@example.com"),
        ];

        public Task<UserDto> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
        {
            var user = MockUsers.FirstOrDefault(u =>
                u.Email.Equals(request.Email, StringComparison.OrdinalIgnoreCase));

            if (user is null)
                throw new KeyNotFoundException($"User with email {request.Email} not found.");

            Console.WriteLine($"[UserManagement] Found user: {user.Email}");
            return Task.FromResult(user);
        }
    }
}
