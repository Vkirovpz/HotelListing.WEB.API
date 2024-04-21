using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.WEB_API.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Bulgaria",
                    ShortName = "BG"
                },
                new Country
                {
                    Id = 2,
                    Name = "Italy",
                    ShortName = "IT"
                },
                new Country
                {
                    Id = 3,
                    Name = "France",
                    ShortName = "FR"
                }
                );
        }
    }
}
