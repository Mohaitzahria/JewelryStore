namespace jewelryStoremvc
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Jewelry>> GetAllJewelries();
        Task<IEnumerable<Jewelry>> GetJewelriesByTermAndGenre(string term, int genreId);
        Task<IEnumerable<Jewelry>> SearchJewelries(string searchTerm);

    }
}