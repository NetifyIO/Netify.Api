using System;
using Netify.Authentication.Models;

namespace Netify.Authentication
{
    public interface IUserSource
    {
        User GetUser(int userId);
        User GetUser(string userName);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
