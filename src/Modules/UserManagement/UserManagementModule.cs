using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserManagement.Data;
using UserManagement.Interfaces;
using UserManagement.Services;

namespace UserManagement;

public static class UserManagementModule
{
    public static IServiceCollection AddUserManagementModule(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<UserDbContext>(options =>
        {
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });
        services.AddScoped<IUserService, UserService>();
        return services;
    }
}
