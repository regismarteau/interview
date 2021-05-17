using System;

namespace Account.Domain
{
    public class UserAccount
    {
        public UserAccount(Guid id, string email, string password)
        {
            this.Id = id;
            this.Email = email;
            this.Password = password;
        }

        public Guid Id { get; }
        public string Email { get; }
        public string Password { get; private set; }

        public void ChangePassword(string newPassword)
        {
            this.Password = newPassword;
        }
    }
}
