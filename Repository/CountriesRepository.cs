using HotelListing.WEB_API.Contracts;
using HotelListing.WEB_API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.WEB_API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;

        public CountriesRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(c => c.Hotels).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
