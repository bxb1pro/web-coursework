using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace2.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime JoinDate { get; set; }
        
    [JsonIgnore]
    public List<Transaction>? Transactions { get; set; } // Navigation to Transactions
    [JsonIgnore]
    public List<Review>? Reviews { get; set; } // Navigation to Review
    [JsonIgnore]
    public List<GameLicense>? GameLicenses { get; set; } // Navigation to GameLicense
}