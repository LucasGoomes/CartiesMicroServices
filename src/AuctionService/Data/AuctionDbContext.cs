using Microsoft.EntityFrameworkCore;
using AuctionService.Entities;

namespace AuctionService.Data;
// Representas a session with the database
// and allows us to query and save entities
public class AuctionDbContext : DbContext
{
    public AuctionDbContext(DbContextOptions options) : base(options)
    {

    }

    // define the entities
    public DbSet<Auction> Auctions { get; set; }
}

