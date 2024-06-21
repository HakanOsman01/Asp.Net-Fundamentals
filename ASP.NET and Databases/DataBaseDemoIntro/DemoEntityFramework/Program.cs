using DemoEntityFramework.Contracts;
using DemoEntityFramework.Data;
using DemoEntityFramework.Services;
using Microsoft.EntityFrameworkCore;

namespace DemoEntityFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

           
            string connection = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services
                .AddDbContext<ProductListDbContext>(opt => opt.UseSqlServer(connection));
            builder.Services.AddScoped<IProductServices, ProductService>();
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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}