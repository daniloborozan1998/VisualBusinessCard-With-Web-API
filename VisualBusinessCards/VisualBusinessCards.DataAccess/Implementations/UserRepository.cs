using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisualBusinessCards.DataAccess.Interface;
using VisualBusinessCards.Domain.Models;

namespace VisualBusinessCards.DataAccess.Implementations
{
    public class UserRepository : IUserRepository
    {
        private VisualBusinessCardsDbContext _visualBusinessCards;

        public UserRepository(VisualBusinessCardsDbContext visualBusinessCards)
        {
            _visualBusinessCards = visualBusinessCards;
        }
        public List<User> GetAll()
        {
            return _visualBusinessCards
                .Users
                .Where(x => x.Role == "Users").ToList();
        }

        public User GetById(int id)
        {
            return _visualBusinessCards
                .Users.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(User entity)
        {
            _visualBusinessCards.Users.Add(entity);
            _visualBusinessCards.SaveChanges();
        }

        public void Update(User entity)
        {
            _visualBusinessCards.Users.Update(entity);
            _visualBusinessCards.SaveChanges();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUsername(string username)
        {
            return _visualBusinessCards.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower());
        }

        public User LoginUser(string username, string password)
        {
            return _visualBusinessCards.Users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower()
                                                                && x.Password == password);
        }
    }
}
