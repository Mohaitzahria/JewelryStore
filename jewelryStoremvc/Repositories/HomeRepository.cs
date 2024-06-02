
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Collections;


namespace jewelryStoremvc.Repositories
{
    public class HomeRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _db;

        public HomeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
       

        
        

        public async Task<IEnumerable<Jewelry>> GetAllJewelries()
        {
            return await _db.Jewelerys
                .Include(j => j.Genre)
                .ToListAsync();
        }

        public Task<IEnumerable<Jewelry>> GetJewelerys(string sTerm = "", int genreId = 0)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Jewelry>> GetJewelriesByTermAndGenre(string term, int genreId)
        {
            term = term.ToLower();

            return await _db.Jewelerys
                .Where(j => string.IsNullOrEmpty(term) || j.JewelryName.ToLower().StartsWith(term))
                .Where(j => genreId <= 0 || j.GenreId == genreId)
                .Include(j => j.Genre)
                .ToListAsync();
        }

        public async Task<IEnumerable<Jewelry>> SearchJewelries(string searchTerm)
        {
            searchTerm = searchTerm.ToLower();

            return await _db.Jewelerys
                .Where(j => string.IsNullOrEmpty(searchTerm) || j.JewelryName.ToLower().Contains(searchTerm))
                .Include(j => j.Genre)
                .ToListAsync();
        }
    }

}
