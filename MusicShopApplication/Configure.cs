<<<<<<< HEAD
﻿using MusicShop.DAL.Interfaces;
using MusicShop.DAL.Repositories;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;
using MusicShop.Service.Services;

namespace MusicShopApplication
{
    public static class Configure
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<User>, UserRepository>();
            services.AddScoped<IRepository<Product>, ProductRepository>();
            services.AddScoped<IRepository<Basket>, BasketRepository>();
            services.AddScoped<IRepository<Order>, OrderRepository>();
            services.AddScoped<IRepository<Comment>, CommentRepository>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<ICommentService, CommentService>();
        }
    }
}
=======
﻿using MusicShop.DAL.Interfaces;
using MusicShop.DAL.Repositories;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;
using MusicShop.Service.Services;

namespace MusicShopApplication
{
    public static class Configure
    {
        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<User>, UserRepository>();
            services.AddScoped<IRepository<Product>, ProductRepository>();
            services.AddScoped<IRepository<Basket>, BasketRepository>();
            services.AddScoped<IRepository<Order>, OrderRepository>();
            services.AddScoped<IRepository<Comment>, CommentRepository>();
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<ICommentService, CommentService>();
        }
    }
}
>>>>>>> af62f584d277b5fbe75b59c07e356b9ea25a83f0
