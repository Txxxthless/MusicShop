<<<<<<< HEAD
﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicShop.Domain.Entity;

namespace MusicShop.DAL.DbConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> configurer)
        {
            configurer.ToTable("Orders").HasKey(order => order.Id);

            configurer.Property(order => order.Id).ValueGeneratedOnAdd();

            configurer.HasOne(order => order.Basket).WithMany(basket => basket.Orders).HasForeignKey(order => order.BasketId);
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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> configurer)
        {
            configurer.ToTable("Orders").HasKey(order => order.Id);

            configurer.Property(order => order.Id).ValueGeneratedOnAdd();

            configurer.HasOne(order => order.Basket).WithMany(basket => basket.Orders).HasForeignKey(order => order.BasketId);
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
