using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TaskBoardApp.Data
{
    public class Task
    {
        [Key]
        [Comment("The identifier for the task")]
        public int Id { get; set; }
        [Required]
        [MaxLength(DataConstants.TaskConstansts.MaxTitleTaskMaxLenght)]
        public string Title { get; set; }=string.Empty;

    }
}
//· Id – a unique integer, Primary Key

//· Title – a string with min length 5 and max length 70 (required)

//· Description – a string with min length 10 and max length 1000 (required)

//· CreatedOn – date and time

//· BoardId – an integer

//· Board – a Board object

//· OwnerId – an integer (required)

//· Owner – an IdentityUser object
