using Microsoft.AspNetCore.Identity;
using Petstore_GroupProject8.Models;
using System;
using System.Collections.Generic;

namespace Petstore_GroupProject8.Models
{
    public class Customer : IdentityUser
    {
        public string Fullname { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
