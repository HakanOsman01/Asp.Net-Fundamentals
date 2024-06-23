using System.ComponentModel.DataAnnotations;
using static ForumApp.Infrastructer.Constants.ValidationConstants;

namespace ForumApp.Core.Models
{
    /// <summary>
    /// Data transfer object
    /// </summary>
    public class PostModel
    {
        /// <summary>
        /// This is the id for view model
        /// </summary>
        public int Id { get; set; }
        [Required(ErrorMessage =RequiredErrorMessage)]
        [StringLength(TitleMaxLenght,MinimumLength =TitleMinLenght,ErrorMessage 
            =StringLenghtErrorMessage)]
        /// <summary>
        /// This is the title for view model
        /// </summary>
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage =RequiredErrorMessage)]
        [StringLength(ContextMaxLenght,MinimumLength =ContextMinLenght
            ,ErrorMessage =StringLenghtErrorMessage)]
        /// <summary>
        /// This is the context for view model
        /// </summary>
        public string Content { get; set; }=string.Empty;
    }
}
