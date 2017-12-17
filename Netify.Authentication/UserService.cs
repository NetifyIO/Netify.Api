using System;
using Netify.Authentication.Exceptions;
using Netify.Authentication.Models;

namespace Netify.Authentication
{
    public class UserService
    {
        private IUserSource _userSource;

        // TODO: Authorization checks.
        public UserService(IUserSource userSource)
        {
            _userSource = userSource;
        }

        public bool Authenticate(string userName, string password)
        {
            var user = GetUser(userName);
            if (user == null) return false;
            return user.Password == password;
        }

        public User GetUser(string userName)
        {
            return _userSource.GetUser(userName);
        }

        public void AddUser(User user)
        {
            var existing = GetUser(user.UserName);
            if (existing != null) 
                throw new CreateUserException($"User with username {user.UserName} already exists.");

            _userSource.AddUser(user);
        }
    }
}
