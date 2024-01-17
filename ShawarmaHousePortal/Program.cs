using Infrastrucure.IRepository;
using Infrastrucure.IRepository.ServicesRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NuGet.Protocol.Core.Types;
using ShawarmaHousePortal.Data;
using ShawarmaHousePortal.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("ShawarmaHousePortal.Infrastrucure")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped< IServicesRepository < Job > , ServicesJob>();
builder.Services.AddScoped< IServicesRepository < Gender > , ServicesGender>();
builder.Services.AddScoped< IServicesRepository < Maried > , ServicesMaried>();
builder.Services.AddScoped< IServicesRepository < City > , ServiceCity>();
builder.Services.AddScoped< IServicesRepository < Employee > , EmployeeRepository>();
builder.Services.AddScoped< IServicesRepository < Education > , EducationService>();
builder.Services.AddScoped< IServicesRepository < Work > , WorkService>();

//builder.Services.AddTransient(typeof(INewServices<>), typeof(MainRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
           name: "areas",
           pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
         );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
