using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace TaskBoardApp.Data
{
    public class Board
    {
        [Key]

        public int Id { get; set; }
        [Required]
        [MaxLength(DataConstants.BoardConstants.MaxNameBoardLenght)]
        public string Name { get; set; } = string.Empty;
        public IEnumerable<Task> Tasks { get; set; } =new List<Task>();
    }
}