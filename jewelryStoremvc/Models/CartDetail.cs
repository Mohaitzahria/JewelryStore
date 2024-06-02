using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace jewelryStoremvc.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id { get; set; }
        [Required]

        public int ShoppingCartId { get; set; }
        [Required]
        public int JewelryId { get; set; }
        [Required]

        public int Quantity { get; set; }
        public Jewelry Jewelry { get; set; }

        public ShoppingCart ShoppingCart { get; set; }










    }
}
