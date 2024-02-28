using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace2.Models;

public class GameUpdate
{
    public int GameUpdateId { get; set; } 
    public int GameId { get; set; } // FK to Game
    public string Version { get; set; }

    [JsonIgnore]
    public Game? Game { get; set; } // Link to Game (FK)
}