using System.ComponentModel.DataAnnotations;

namespace Petstore_GroupProject8.Models
{
    public class Category
    {
      
        [Key]
        public int CategoryId { get; set; }

        [Required, MaxLength(45)]
        public string CategoryName { get; set; } = string.Empty;

        [MaxLength(450)]
        public string Description { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }

}
