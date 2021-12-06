using System;
using System.Collections.Generic;
using System.Text;
using VisualBusinessCards.Domain.Models;

namespace VisualBusinessCards.DataAccess.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByUsername(string username);
        User LoginUser(string username, string password);
    }
}
