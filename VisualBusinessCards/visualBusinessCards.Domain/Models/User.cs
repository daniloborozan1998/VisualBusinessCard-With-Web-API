using System;
using System.Collections.Generic;
using System.Text;

namespace VisualBusinessCards.Domain.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
    }
}
