using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetaMonkeysStore.ServerApp.Data
{
    public class InvoiceItem
    {
        public static int Count = 0;
        [Key]
        public string InvoiceItemID { get; set; }

        [Required]
        public string InvoiceID { get; set; }

        [Required]
        public string ItemID { get; set; }

        [Required]
        public int Quantity { get; set; }

        /*[Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal UnitCost { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalCost { get; set; }*/

        [ForeignKey("InvoiceID")]
        public Invoice Invoice { get; set; } // An invoice item belongs to a single invoice

        [ForeignKey("ItemID")]
        public Item Item { get; set; } // An item entry in an invoice contains an inventory item
    }
}