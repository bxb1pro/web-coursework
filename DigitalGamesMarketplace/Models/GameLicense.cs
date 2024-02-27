using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace.Models
{
    public class GameLicense
    {
        public int GameLicenseId { get; set; } 
        public int GameId { get; set; } // FK to Game
        public string LicenseKey { get; set; }

        [JsonIgnore]
        public Game? Game { get; set; } // Link to Game (FK)
    }
}