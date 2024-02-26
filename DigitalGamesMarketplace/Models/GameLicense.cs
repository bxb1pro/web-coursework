using System.Collections.Generic;

namespace DigitalGamesMarketplace.Models
{
    public class GameLicense
    {
        public int GameLicenseId { get; set; } 
        public int UserId { get; set; } // FK to User
        public int GameId { get; set; } // FK to Game
        public string LicenseKey { get; set; }

        public User? User { get; set; } // Link to User (FK)
        public Game? Game { get; set; } // Link to Game (FK)
    }
}