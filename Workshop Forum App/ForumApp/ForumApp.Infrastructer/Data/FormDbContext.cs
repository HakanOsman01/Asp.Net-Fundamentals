using ForumApp.Infrastructer.Data.Configuration;
using ForumApp.Infrastructer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Infrastructer.Data
{
    public class FormDbContext : DbContext
    {
        public FormDbContext(DbContextOptions<FormDbContext> options)
            : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>();
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
