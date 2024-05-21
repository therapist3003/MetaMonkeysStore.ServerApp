using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetaMonkeysStore.ServerApp.Data
{
    public class Item
    {
        [Key]
        public string ItemID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal UnitCost { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal GST {  get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Discount { get; set; }

        //public ICollection<InvoiceItem> InvoiceItems { get; set; } // One inventory item is related to an invoice item entry
    }
}
