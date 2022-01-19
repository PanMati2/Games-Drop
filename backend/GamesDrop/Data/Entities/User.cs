using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace GamesDrop.Data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<Order> Orders { get; set; }
        public Cart Cart { get; set; }
    }
}