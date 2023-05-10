using Microsoft.EntityFrameworkCore;
using TEntity.Domain.Entities.Users;

namespace TEntity.DAL.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
