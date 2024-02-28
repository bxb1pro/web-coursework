using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DigitalGamesMarketplace.Models
{
    public class MarketplaceContext : IdentityDbContext<IdentityUser>
    {
        public MarketplaceContext(DbContextOptions<MarketplaceContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<GameLicense> GameLicenses { get; set; }
        public DbSet<GameUpdate> GameUpdates { get; set; }
    }
}