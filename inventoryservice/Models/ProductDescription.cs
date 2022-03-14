using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inventoryservice.Models
{
   [Owned]
    public class ProductDescription
    {
        [Column("Product_Name")]
        [Required]
        [StringLength(100)]        
        public string ProductName { get; set; }
        
        [Column("Product_Description")]
        public string? Description { get; set; }
        [Column("DOP")]
        public DateTime DOP { get; set; }
        [Column("Buffer_Level")]
        public long BufferLevel { get; set; }

        [DisplayName("Price")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Column("Unit_Price")]
        public decimal UnitPrice { get; set; }

    }
}
