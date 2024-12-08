using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Petstore_GroupProject8.Models;

namespace Petstore_GroupProject8.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("Customer")]
        public string CustomerId { get; set; } = string.Empty;
        public Customer Customer { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalAmount { get; set; }

        [MaxLength(45)]
        public string Status { get; set; } = string.Empty;

        [MaxLength(300)]
        public string ShippingAddress { get; set; } = string.Empty;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}

