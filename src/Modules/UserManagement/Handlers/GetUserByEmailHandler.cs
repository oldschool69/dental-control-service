using MediatR;
using UserManagement.Queries;

namespace UserManagement.Handlers
{
    public class GetUserByEmailHandler : IRequestHandler<GetUserByEmailQuery, UserDto>
    {
        // This could be replaced by a real database in the future
        private static readonly List<UserDto> MockUsers =
        [
            new(Guid.NewGuid(), "alice@example.com"),
            new(Guid.NewGuid(), "bob@example.com"),
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
