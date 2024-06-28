using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskBoardApp.Data.Configuretion;

namespace TaskBoardApp.Data.SeedData
{
    public class TaskConfiguretion : IEntityTypeConfiguration<Task>
    {
      

        public void Configure(EntityTypeBuilder<Task> builder)
        {
                builder
               .HasOne(t => t.Board)
               .WithMany(b => b.Tasks)
               .HasForeignKey(b => b.BoardId)
               .OnDelete(DeleteBehavior.Restrict);

               builder.HasData(SeedTasks());
        }

       

        private IEnumerable<Task> SeedTasks()
        {
            Task[] tasks = new Task[]
            {
                new Task()
                {
                    Id=1,
                    Title="Impove CSS styles",
                    Description="Improve better styling for all public pages",
                    CreatedOn = DateTime.Now.AddDays(-200),
                    OwnerId= ConfigurationHelper.testUser.Id,
                    BoardId=ConfigurationHelper.openBoard.Id
                },
                new Task()
                {
                    Id=2,
                    Title="Android Client App",
                    Description="Created Android client app for the TaskBoard RESTful API",
                    OwnerId=ConfigurationHelper.testUser.Id,
                    CreatedOn = DateTime.Now.AddDays(-100),
                    BoardId=ConfigurationHelper.inProgressBoard.Id
                },
                new Task()
                {
                    Id=3,
                    Title="Desktop Id Client",
                    Description="Create Windows Forms desktop app client for the TaskBoard RESTful API",
                    OwnerId=ConfigurationHelper.testUser.Id,
                     CreatedOn = DateTime.Now.AddDays(-10),
                    BoardId=ConfigurationHelper.doneBoard.Id,
                }
              
            };
            return tasks;
        }
    }
}
