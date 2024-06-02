using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jewelryStoremvc.Models
{
    [Table("Jewelry")]
    public class Jewelry
    {
        public int Id { get; set; }
        [Required]

        [MaxLength(100)]

        public string? JewelryName { get; set; }
        [Required]

        public double  Price { get; set; }

        public  string?  image { get; set; }
        [Required]

        
        

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public List<OrderDetail> OrderDetail { get; set; }

        public List<CartDetail> CartDetail { get; set; }

        [NotMapped]
        public string GenreName { get; set; }










    }
}
