using Microsoft.AspNetCore.Http.Features;

namespace AuctionService.Entities;

// Represents an auction - a table in the database
public class Auction
{
    public Guid Id { get; set; }
    public int ReservePrice { get; set; } = 0;
    public string Seller { get; set; }
    public string Winner { get; set; }
    public int? SoldMount { get; set; }
    public int? CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime AuctionEnd { get; set; } = DateTime.UtcNow;

    public Status Status { get; set; }
    public Item Item { get; set; }
}