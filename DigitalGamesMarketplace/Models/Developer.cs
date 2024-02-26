using System.Collections.Generic;

namespace DigitalGamesMarketplace.Models
{
    public class Developer
    {
        public int DeveloperId { get; set; }
        public string Name { get; set; }
        public string ContactEmail { get; set; }

        public List<Game>? Games { get; set; } // Link to Game (one to many)
    }
}