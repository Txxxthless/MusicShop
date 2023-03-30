using Microsoft.EntityFrameworkCore;
using MusicShop.Domain.Entity;

namespace MusicShop.DAL
{
    public class ApplicationDataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDataBaseContext(DbContextOptions<ApplicationDataBaseContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
