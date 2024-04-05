using Microsoft.EntityFrameworkCore;

namespace HotelListing.WEB_API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
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
                });

            modelBuilder.Entity<Hotel>().HasData(
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
