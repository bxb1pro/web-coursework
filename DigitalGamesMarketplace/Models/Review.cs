using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace2.Models;

public class Review
{
    public int ReviewId { get; set; }
    public int GameId { get; set; } // FK to Game
    public int CustomerId { get; set; } // FK to Customer
    public int Rating { get; set; }
    public DateTime ReviewDate { get; set; }
        

    [JsonIgnore]
    public Game? Game { get; set; } // Link to Game (FK)
    [JsonIgnore]
    public Customer? Customer { get; set; } // Link to Customer (FK)
}