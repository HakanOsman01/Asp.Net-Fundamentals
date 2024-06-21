using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEntityFramework.Data.Models
{
    public class ProductNode
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Content { get; set; } = string.Empty;
        [Required]
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

    }
}