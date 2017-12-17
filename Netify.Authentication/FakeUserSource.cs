using System;
using System.Collections.Generic;
using System.Linq;
using Netify.Authentication.Models;

namespace Netify.Authentication
{
    public class FakeUserSource : IUserSource
    {
        private List<User> _users { get; } = new List<User>()
        {
            new User()
            {
                Id = 1,
                Created = DateTime.Now.AddDays(-2),
                Updated = DateTime.Now.AddDays(-1),
                UserName = "Brandon",
                Email = "brandonclapp@outlook.com",
                Password = "password123"
            }
        };

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void DeleteUser(int userId)
        {
            var user = _users.First(u => u.Id == userId);
            _users.Remove(user);
        }

        public User GetUser(string userName) 
        {
            return _users.FirstOrDefault(u => u.UserName.ToLower() == userName.ToLower());
        }

        public User GetUser(int userId)
        {
            return _users.FirstOrDefault(u => u.Id == userId);
        }

        public void UpdateUser(User user)
        {
            var update = _users.Find(u => u.Id == user.Id);
            update = user; // make sure this is the reference that we're editing.
        }
    }
}
