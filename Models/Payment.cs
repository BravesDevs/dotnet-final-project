using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Petstore_GroupProject8.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public DateTime PaymentDate { get; set; }

        [MaxLength(45)]
        public string PaymentMethod { get; set; }

        [MaxLength(45)]
        public string PaymentStatus { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
    }
}
