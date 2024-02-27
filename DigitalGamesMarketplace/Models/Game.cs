using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public int DeveloperId { get; set; } // FK for Developer

        [JsonIgnore]
        public Developer? Developer { get; set; } // Link to Developer (FK)
    }
}