using System.Collections.Generic;

namespace DigitalGamesMarketplace.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public List<User>? Users { get; set; } // Link to User (one to many)
    }   
}