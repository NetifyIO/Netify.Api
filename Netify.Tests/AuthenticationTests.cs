using System;
using Netify.Authentication;
using Xunit;

namespace Netify.Tests
{
    public class AuthenticationTests
    {
        private IUserSource _userSource;

        public AuthenticationTests()
        {
            _userSource = new FakeUserSource();
        }

        [Fact]
        public void ShouldGetUser()
        {
            var user = _userSource.GetUser("Brandon");
            Assert.NotNull(user);
        }
    }
}
