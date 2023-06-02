<<<<<<< HEAD
﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicShop.Domain.Entity;

namespace MusicShop.DAL.DbConfiguration
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> configurer)
        {
            configurer.ToTable("Baskets").HasKey(basket => basket.Id);

            configurer.Property(basket => basket.Id).ValueGeneratedOnAdd();

            configurer.HasData(new Basket()
            {
                Id = 1,
                UserId = 1
            });
        }
    }
}
=======
﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicShop.Domain.Entity;

namespace MusicShop.DAL.DbConfiguration
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> configurer)
        {
            configurer.ToTable("Baskets").HasKey(basket => basket.Id);

            configurer.Property(basket => basket.Id).ValueGeneratedOnAdd();

            configurer.HasData(new Basket()
            {
                Id = 1,
                UserId = 1
            });
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
