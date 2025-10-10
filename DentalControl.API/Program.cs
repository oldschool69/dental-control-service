using Microsoft.OpenApi.Models;

using Authentication;
using UserManagement;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Dental Control API",
        Version = "v1",
        Description = "API Dental Control System",
    });
});

// Register modules
builder.Services.AddAuthenticationModule();
builder.Services.AddUserManagementModule();


builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(AuthenticationModule).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(UserManagementModule).Assembly);
});


var app = builder.Build();

// Enable Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// Module endpoints registration
app.MapControllers();

app.Run();
