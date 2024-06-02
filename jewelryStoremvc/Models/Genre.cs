using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jewelryStoremvc.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }
        [Required]

        [MaxLength(100)]

        public string? GenreName { get; set; }

        public List<Jewelry> Jewelerys { get; set; }


        



    }


}

