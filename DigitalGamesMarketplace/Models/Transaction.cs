using System.Collections.Generic;

namespace DigitalGamesMarketplace.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; } // FK to User
        public int GameId { get; set; } // FK to Game
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }

        public User? User { get; set; } // Link to User (FK)
        public Game? Game { get; set; } // Link to Game (FK)
    }
}