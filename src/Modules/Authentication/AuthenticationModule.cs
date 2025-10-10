using Authentication.Interfaces;
using Authentication.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication;

public static class AuthenticationModule
{
    public static IServiceCollection AddAuthenticationModule(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        return services;
    }
}
