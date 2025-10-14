using Microsoft.EntityFrameworkCore;
using Authentication.Entities;

namespace Authentication.Data
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

        public DbSet<Login> Logins { get; set; }

    }
}
