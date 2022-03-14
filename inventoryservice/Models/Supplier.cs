using System.ComponentModel.DataAnnotations.Schema;

namespace inventoryservice.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }



    }
}
