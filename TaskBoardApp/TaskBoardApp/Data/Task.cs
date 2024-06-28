using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskBoardApp.Data
{
    public class Task
    {
        [Key]
        [Comment("The identifier for the task")]
        public int Id { get; set; }
        [Required]
        [MaxLength(DataConstants.TaskConstansts.MaxTitleTaskLenght)]
        public string Title { get; set; }=string.Empty;
        [Required]
        [MaxLength(DataConstants.TaskConstansts.MaxDescriptionLenght)]
        public string Description { get; set; } = string.Empty;
      
        public DateTime? CreatedOn { get; set; }
        public int BoardId { get; set; }
        [Required]
        public string OwnerId { get; set; } = string.Empty;
        [ForeignKey(nameof(BoardId))]
        public Board? Board { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public IdentityUser Owner { get; set; } = null!;

    }
}

