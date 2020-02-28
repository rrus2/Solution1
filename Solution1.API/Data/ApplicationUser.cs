using Microsoft.AspNetCore.Identity;
using Solution1.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solution1.API.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Orders = new HashSet<Order>();
        }
        public DateTime Birthdate { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
