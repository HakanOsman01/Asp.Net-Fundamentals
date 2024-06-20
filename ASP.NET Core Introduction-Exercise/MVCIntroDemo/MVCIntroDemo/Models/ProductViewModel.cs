namespace MVCIntroDemo.Models
{
    /// <summary>
    /// Product Model
    /// </summary>
    public class ProductViewModel
    {
        /// <summary>
        /// Id for ProductViewModel
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the product
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Price of the product
        /// </summary>
        public double Price { get; set; }
    }
}
