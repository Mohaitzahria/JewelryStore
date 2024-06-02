using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jewelryStoremvc.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]

      

        public int JewelryId { get; set; }
        [Required]

        public int Quantity { get; set; }
        [Required]

        public double UnitPrice { get; set; }

        public Order Order { get; set; }

        public Jewelry Jewelry { get; set; }






    }
}
