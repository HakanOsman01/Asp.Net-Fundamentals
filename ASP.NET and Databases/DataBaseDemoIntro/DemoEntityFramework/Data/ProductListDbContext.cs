using DemoEntityFramework.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEntityFramework.Data
{
    public class ProductListDbContext : DbContext
    {
        public ProductListDbContext(DbContextOptions<ProductListDbContext> options)
            :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Id=1,
                Name = "Cheese"
            }, new Product()
            {
                Id=2,
                Name="Ham"
            }
            );

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductNode>ProductNodes { get; set; }
    }
}
