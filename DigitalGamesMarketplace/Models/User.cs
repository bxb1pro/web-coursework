using System.Collections.Generic;

namespace DigitalGamesMarketplace.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public int RoleId { get; set; } // FK for Role

        public Role? Role { get; set; } // Link to Role (FK)
    }
}