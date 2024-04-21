using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.WEB_API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Victoria Palace",
                    Address = "Sunny Beach",
                    CountryId = 1,
                    Rating = 5.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "CR7",
                    Address = "Monaco",
                    CountryId = 2,
                    Rating = 7.0
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Paris Palace",
                    Address = "Paris",
                    CountryId = 3,
                    Rating = 6.3
                });
        }
    }
}
