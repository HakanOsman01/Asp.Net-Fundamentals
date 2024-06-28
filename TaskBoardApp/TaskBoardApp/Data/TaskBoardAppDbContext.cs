using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data.Configuretion;
using TaskBoardApp.Data.SeedData;

namespace TaskBoardApp.Data
{
    public class TaskBoardAppDbContext : IdentityDbContext
    {
        public TaskBoardAppDbContext(DbContextOptions<TaskBoardAppDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new BoardConfiguration());
            builder.ApplyConfiguration(new TaskConfiguretion());
          

            base.OnModelCreating(builder);
        }
        public DbSet<Task> Tasks { get; set;}
        public DbSet<Board> Boards { get; set;}
       
    }
}