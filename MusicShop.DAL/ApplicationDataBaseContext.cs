using Microsoft.EntityFrameworkCore;
using MusicShop.DAL.DbConfiguration;
using MusicShop.Domain.Entity;
using MusicShop.Domain.Helpers;
using System.Reflection.Emit;

namespace MusicShop.DAL
{
    public class ApplicationDataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDataBaseContext(DbContextOptions<ApplicationDataBaseContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            //builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new BasketConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
        }
    }
}
