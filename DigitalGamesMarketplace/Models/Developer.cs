using System.Text.Json.Serialization;

namespace DigitalGamesMarketplace2.Models;

public class Developer
{
    public int DeveloperId { get; set; }
    public string Name { get; set; }
    public string ContactEmail { get; set; }

    [JsonIgnore]
    public List<Game>? Games { get; set; } // Link to Game (one to many)
}