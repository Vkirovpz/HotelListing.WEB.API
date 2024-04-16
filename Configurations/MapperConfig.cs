using AutoMapper;
using HotelListing.WEB_API.Data;
using HotelListing.WEB_API.Models.Country;
using HotelListing.WEB_API.Models.Hotel;

namespace HotelListing.WEB_API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Country, UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
        }
    }
}
