using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace inventoryservice.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("Product_Id")]
        public long ProductId { get; set; }
        //value object
        public ProductDescription ProductDescription { get; set; }

     
    }
}
