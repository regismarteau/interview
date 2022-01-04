using FluentAssertions;
using NUnit.Framework;

namespace Account.Domain.UnitTests
{
    [TestFixture]
    public class UserAccountTests
    {
        [Test]
        public void The_password_of_an_user_account_could_be_changed()
        {
            UserAccount userAccount = new UserAccount("my_custom_mail@email.com", "@Azerty123");
            
            userAccount.ChangePassword("@Azerty456");
            
            userAccount.Password
                .Should()
                .Be("@Azerty456");
        }
    }
}
