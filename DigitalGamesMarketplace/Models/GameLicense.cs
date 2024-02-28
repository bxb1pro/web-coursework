using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace2.Models;

public class GameLicense
{
    public int GameLicenseId { get; set; } 
    public int GameId { get; set; } // FK to Game
    public int CustomerId { get; set; } // FK to Customer
    public string LicenseKey { get; set; }
    public DateTime PurchaseDate { get; set; }

    [JsonIgnore]
    public Game? Game { get; set; } // Link to Game (FK)
    [JsonIgnore]
    public Customer? Customer { get; set; } // Link to Customer (FK)
}