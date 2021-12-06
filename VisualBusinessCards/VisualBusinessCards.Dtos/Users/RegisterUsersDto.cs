using System;
using System.Collections.Generic;
using System.Text;

namespace VisualBusinessCards.Dtos.Users
{
    public class RegisterUsersDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
        public string Role { get; set; }
    }
}
