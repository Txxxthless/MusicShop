<<<<<<< HEAD
﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicShop.Domain.Entity;

namespace MusicShop.DAL.DbConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> configurer)
        {
            configurer.ToTable("Products").HasKey(product => product.Id);

            configurer.Property(product => product.Id).ValueGeneratedOnAdd();

            configurer.HasData(new Product[]
            {
                    new Product()
                    {
                        Id = 1,
                        Manufacturer = "Fender",
                        Model = "Jaguar",
                        Description = "A very beautiful one",
                        Type = Domain.Enum.InstrumentType.String,
                        Image = File.ReadAllBytes(@"D:\\CS Projects\\MusicShop\\Images\\jaguar.jpg"),
                        Price = 500
                    },
                    new Product()
                    {
                        Id = 2,
                        Manufacturer = "Fender",
                        Model = "Stratocaster",
                        Description = "A very convinient guitar",
                        Type = Domain.Enum.InstrumentType.String,
                        Image = File.ReadAllBytes(@"D:\\CS Projects\\MusicShop\\Images\\stratocaster.png"),
                        Price = 700
                    },
                    new Product()
                    {
                        Id = 3,
                        Manufacturer = "Gibson",
                        Model = "Les Paul",
                        Description = "A very good guitar",
                        Type = Domain.Enum.InstrumentType.String,
                        Image = File.ReadAllBytes(@"D:\\CS Projects\\MusicShop\\Images\\gibson.jpg"),
                        Price = 750
                    },
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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> configurer)
        {
            configurer.ToTable("Products").HasKey(product => product.Id);

            configurer.Property(product => product.Id).ValueGeneratedOnAdd();

            configurer.HasData(new Product[]
            {
                    new Product()
                    {
                        Id = 1,
                        Manufacturer = "Fender",
                        Model = "Jaguar",
                        Description = "A very beautiful one",
                        Type = Domain.Enum.InstrumentType.String,
                        Image = File.ReadAllBytes(@"D:\\CS Projects\\MusicShop\\Images\\jaguar.jpg"),
                        Price = 500
                    },
                    new Product()
                    {
                        Id = 2,
                        Manufacturer = "Fender",
                        Model = "Stratocaster",
                        Description = "A very convinient guitar",
                        Type = Domain.Enum.InstrumentType.String,
                        Image = File.ReadAllBytes(@"D:\\CS Projects\\MusicShop\\Images\\stratocaster.png"),
                        Price = 700
                    },
                    new Product()
                    {
                        Id = 3,
                        Manufacturer = "Gibson",
                        Model = "Les Paul",
                        Description = "A very good guitar",
                        Type = Domain.Enum.InstrumentType.String,
                        Image = File.ReadAllBytes(@"D:\\CS Projects\\MusicShop\\Images\\gibson.jpg"),
                        Price = 750
                    },
            });
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
