using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace2.Models;

public class Game
{
    public int GameId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Genre { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int DeveloperId { get; set; } // FK for Developer

    [JsonIgnore]
    public Developer? Developer { get; set; } // Link to Developer (FK)
    [JsonIgnore]
    public List<GameUpdate>? GameUpdates { get; set; } // Navigation to GameUpdate
    [JsonIgnore]
    public List<Review>? Reviews { get; set; } // Navigation to Review
    [JsonIgnore]
    public List<GameLicense>? GameLicenses { get; set; } // Navigation to GameLicense
    [JsonIgnore]
    public List<Transaction>? Transactions { get; set; } // Navigation to Transactions
}