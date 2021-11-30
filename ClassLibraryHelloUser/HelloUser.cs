using System;
using System.Linq;

namespace ClassLibraryHelloUser
{
    public class HelloUser : IHelloUser
    {
        private string userName;
        private string userEmail;
        private string validationMessage;

        public HelloUser()
        {
        }

        public HelloUser(string userName, string userEmail)
        {
            this.validationMessage = Validator.ValidateData(userName, userEmail);

            if (string.IsNullOrEmpty(validationMessage))
            {
                userName = FormatName(userName);
            }

            this.userName = userName;
            this.userEmail = userEmail;
        }

        public string Greetings => string.IsNullOrEmpty(validationMessage) ? $"{DateTime.Now:HH:mm.ss} Hello {this.userName}, {this.userEmail}!" : validationMessage;

        public void Init(string userName, string userEmail)
        {
            this.validationMessage = Validator.ValidateData(userName, userEmail);

            if (string.IsNullOrEmpty(validationMessage))
            {
                userName = FormatName(userName);
            }

            this.userName = userName;
            this.userEmail = userEmail;
        }

        private static string FormatName(string userName)
        {
            userName = string.Join(" ", userName.Split().Select(s => char.ToUpper(s[0]) + s.Substring(1, s.Length - 1)));
            return userName;
        }
    }
}
