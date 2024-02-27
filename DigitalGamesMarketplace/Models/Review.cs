using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int GameId { get; set; } // FK to Game
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }

        [JsonIgnore]
        public Game? Game { get; set; } // Link to Game (FK)
    }
}