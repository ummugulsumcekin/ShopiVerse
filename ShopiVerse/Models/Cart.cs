using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopiVerse.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }

}
