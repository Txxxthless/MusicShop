using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using MusicShop.DAL;
using MusicShop.DAL.Interfaces;
using MusicShop.DAL.Repositories;
using MusicShop.Domain.Entity;
using MusicShop.Service.Interfaces;
using MusicShop.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
        options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
    });

//db register
builder.Services.AddDbContext<ApplicationDataBaseContext>(options => options.UseSqlServer(connectionString));
//add user repo
builder.Services.AddScoped<IRepository<User>, UserRepository>();
//add prod repo
builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
//add account service
builder.Services.AddScoped<IAccountService, AccountService>();
//add prod service
builder.Services.AddScoped<IProductService, ProductService>();
//add user service
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
