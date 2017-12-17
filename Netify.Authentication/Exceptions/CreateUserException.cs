using System;
namespace Netify.Authentication.Exceptions
{
    public class CreateUserException : Exception
    {
        public CreateUserException(string message) : base(message)
        {
            
        }
    }
}
