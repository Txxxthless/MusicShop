
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicShop.Domain.Entity;
using MusicShop.Domain.Helpers;

namespace MusicShop.DAL.DbConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> configurer)
        {
            configurer.ToTable("Users").HasKey(user => user.Id);

            configurer.HasData(new User()
            {
                Id = 1,
                Name = "Admin",
                Password = PasswordHelper.HashPassword("12345"),
                Role = Domain.Enum.Role.Admin
            });

            configurer.Property(user => user.Id).ValueGeneratedOnAdd();
            configurer.Property(user => user.Name).IsRequired();
            configurer.Property(user => user.Password).IsRequired();

            configurer.HasOne(user => user.Basket)
                    .WithOne(basket => basket.User)
                    .HasPrincipalKey<User>(user => user.Id)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
