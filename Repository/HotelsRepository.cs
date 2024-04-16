using HotelListing.WEB_API.Contracts;
using HotelListing.WEB_API.Data;

namespace HotelListing.WEB_API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext _context;

        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
