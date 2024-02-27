using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int GameId { get; set; } // FK to Game
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }

        [JsonIgnore]
        public Game? Game { get; set; } // Link to Game (FK)
    }
}