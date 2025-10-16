using Microsoft.OpenApi.Models;

using Authentication;
using UserManagement;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("Connection string is not configured.");
}

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
builder.Services.AddAuthenticationModule(connectionString);
builder.Services.AddUserManagementModule(connectionString);


builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(AuthenticationModule).Assembly);
    cfg.RegisterServicesFromAssembly(typeof(UserManagementModule).Assembly);
});

builder.Services.AddAutoMapper(typeof(UserMappingProfile));


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
