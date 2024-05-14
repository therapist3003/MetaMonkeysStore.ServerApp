using System.ComponentModel.DataAnnotations;

namespace MetaMonkeysBillingSystem.App.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Phone { get; set; } = null!;

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = null!;

        [Required]
        public DateTime DOB { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        public ICollection<Invoice> Invoices { get; set; } // One customer has a collection of orders, hence a collection of invoices
    }
}
