using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskBoardApp.Data;

namespace TaskBoardApp.Models
{
    public class TaskViewModel
    {
       
        public int Id { get; set; }
        [Required]
        [StringLength(DataConstants.TaskConstansts.MaxTitleTaskLenght,MinimumLength
            =DataConstants.TaskConstansts.MinTitleTaskLenght)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(DataConstants.TaskConstansts.MaxDescriptionLenght
            ,MinimumLength = DataConstants.TaskConstansts.MinDescriptionLenght)]
        public string Description { get; set; } = string.Empty;

         public DateTime  { get;set; }
        public int? BoardId { get; set; }
        [Required]
        public string Owner { get; set; } = string.Empty;
     
      

    }
}
