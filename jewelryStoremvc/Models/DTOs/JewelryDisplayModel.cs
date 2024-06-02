namespace jewelryStoremvc.Models.DTOs
{
    public class JewelryDisplayModel
    {
        public IEnumerable<Jewelry> jewelrys { get; set; }
        public IEnumerable<Genre> genres { get; set; }
    }
}
