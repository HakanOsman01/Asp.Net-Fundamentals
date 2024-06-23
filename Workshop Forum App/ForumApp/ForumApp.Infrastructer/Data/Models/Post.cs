using static ForumApp.Infrastructer.Constants.ValidationConstants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForumApp.Infrastructer.Data.Models
{
    [Comment("Table Post")]
    public class Post
    {
        [Key]
        [Comment("PostIdentifier")]
        public int Id { get; set; }
        [Required]
        [Comment("Title of the post")]
        [MaxLength(ContextMaxLenght)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Comment("Post Content")]
        [MaxLength(ContextMaxLenght)]

        public string  Content { get; set; }=string.Empty;
    }
}
