using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShopiVerse.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
       
        public string Surname { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
