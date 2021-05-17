using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Account.Domain.UnitTests
{
    [TestClass]
    public class UserAccountTests
    {
        [TestMethod]
        public void The_password_of_an_user_account_could_be_changed()
        {
            var userAccount = new UserAccount(Guid.NewGuid(), "my_custom_mail@email.com", "@Azerty123");
            userAccount.ChangePassword("@Azerty456");
            userAccount.Password
                .Should()
                .Be("@Azerty456");
        }
    }
}
