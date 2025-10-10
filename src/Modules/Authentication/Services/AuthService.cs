using Authentication.Interfaces;
using MediatR;
using UserManagement.Queries;

namespace Authentication.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMediator _mediator;

        public AuthService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> LoginAsync(string email)
        {
            try
            {
                var user = await _mediator.Send(new GetUserByEmailQuery(email));
                Console.WriteLine($"[Authentication] Login successful for {user.Email}");
                return true;
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"[Authentication] Login failed: {ex.Message}");
                return false;
            }
        }
    }
}
