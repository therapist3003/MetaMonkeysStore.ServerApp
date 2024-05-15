using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetaMonkeysBillingSystem.App.Models
{
    public class Invoice
    {
        public static int Count = 0;
        [Key]
        public int InvoiceID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal TotalAmount { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; } // Check whether making this nullable resolves any future error

        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
