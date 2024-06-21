using System.ComponentModel.DataAnnotations;

namespace DemoEntityFramework.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }=string.Empty;

        public virtual ICollection<ProductNode> ProductNodes { get; set; }
            =new List<ProductNode>(); 

    }
}
