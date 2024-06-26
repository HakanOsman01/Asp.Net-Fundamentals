using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Eventmi.Infrastructer.Models
{
    [Comment("This is table of event")]
    public class Event
    {
        [Key]
        [Comment("This is identifier for event")]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }=string.Empty;
        public DateTime Start { get; set; }=DateTime.Now;
        public DateTime End { get; set; }=DateTime.Now;
        public string Place { get;set; }=string.Empty;
    }
}
