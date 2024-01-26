using System.ComponentModel.DataAnnotations;

namespace ShopiVerse.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

}
