using HotelListing.WEB_API.Data;

namespace HotelListing.WEB_API.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }

}
