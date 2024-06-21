using System.ComponentModel.DataAnnotations;

namespace DemoEntityFramework.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Field {0} is required")]
        [Display(Name="Product name")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="Field {0} must be between {1} and {2}" )]
        public string Name { get; set; } = string.Empty;
    }
}
