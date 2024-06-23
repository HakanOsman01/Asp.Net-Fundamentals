using ForumApp.Core.Contracts;
using ForumApp.Core.Services;
using ForumApp.Infrastructer.Data;
using Microsoft.EntityFrameworkCore;

namespace ForumApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Migration in DataBase
            string options = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<FormDbContext>(opt => opt.UseSqlServer(options));
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IPostService, PostService>();



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