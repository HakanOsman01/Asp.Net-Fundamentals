using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaskBoardApp.Data.Configuretion
{
    public class BoardConfiguration : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.HasData(new Board[]
            {
               ConfigurationHelper.openBoard,
               ConfigurationHelper.inProgressBoard,
               ConfigurationHelper.doneBoard
            });

        }
    }
}
