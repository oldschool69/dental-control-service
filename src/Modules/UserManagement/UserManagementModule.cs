using Microsoft.Extensions.DependencyInjection;
using UserManagement.Interfaces;
using UserManagement.Services;

namespace UserManagement;

public static class UserManagementModule
{
    public static IServiceCollection AddUserManagementModule(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        return services;
    }
}
