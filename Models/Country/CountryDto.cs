using HotelListing.WEB_API.Models.Hotel;

namespace HotelListing.WEB_API.Models.Country
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public List<HotelDto> Hotels { get; set; }
    }
}
