using Microsoft.EntityFrameworkCore;
using UserManagement.Entities;

namespace UserManagement.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<AppUser> Users { get; set; }

    
    }
}
