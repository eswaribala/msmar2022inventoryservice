using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inventoryservice.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("Supplier_Id")]
        public long SupplierId { get; set; }
        [Required]
        [Column("Supplier_Name")]
        [StringLength(100)]
        public string? SupplierName { get; set; }

     


    }
}
