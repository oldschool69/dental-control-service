using Authentication.Data;
using Authentication.Interfaces;
using Authentication.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Authentication;

public static class AuthenticationModule
{
    public static IServiceCollection AddAuthenticationModule(this IServiceCollection services, string connectionString)
    {
            services.AddDbContext<AuthDbContext>(options =>
        {
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });
    
        services.AddScoped<IAuthService, AuthService>();
        return services;
    }
}
