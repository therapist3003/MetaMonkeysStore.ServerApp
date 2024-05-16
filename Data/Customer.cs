using System.ComponentModel.DataAnnotations;

namespace MetaMonkeysStore.ServerApp.Data
{
    public class Customer
    {
        public static int Count = 0;
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string Phone { get; set; } = null!;

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = null!;

        [Required]
        public DateTime DOB { get; set; }

        [StringLength(15)]
        public string City { get; set; } = null!;

        public ICollection<Invoice> Invoices { get; set; } // One customer has a collection of orders, hence a collection of invoices
    }
}
