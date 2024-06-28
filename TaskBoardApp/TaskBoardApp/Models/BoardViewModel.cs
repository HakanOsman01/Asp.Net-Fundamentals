using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using TaskBoardApp.Data;

namespace TaskBoardApp.Models
{
    public class BoardViewModel
    {
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(DataConstants.BoardConstants.MaxNameBoardLenght
            ,MinimumLength =DataConstants.BoardConstants.MinNameBoardLenght)]
        public string Name { get; set; } = string.Empty;
        public IEnumerable<TaskViewModel> Tasks { get; set; }=new List<TaskViewModel>();

    }
}
