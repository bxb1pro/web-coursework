using System.Collections.Generic;

namespace DigitalGamesMarketplace.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int GameId { get; set; } // FK to Game
        public int UserId { get; set; } // FK to User
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }

        public Game? Game { get; set; } // Link to Game (FK)
        public User? User { get; set; } // Link to User (FK)
    }
}