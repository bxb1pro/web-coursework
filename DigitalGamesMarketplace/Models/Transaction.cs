using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace2.Models;

public class Transaction
{
    public int TransactionId { get; set; }
    public int GameId { get; set; } // FK to Game
    public int CustomerId { get; set; } // FK to Customer
    public decimal Amount { get; set; }
    public DateTimeOffset TransactionDate { get; set; }

    [JsonIgnore]
    public Game? Game { get; set; } // Link to Game (FK)
    [JsonIgnore]
    public Customer? Customer { get; set; } // Link to Customer (FK)
}