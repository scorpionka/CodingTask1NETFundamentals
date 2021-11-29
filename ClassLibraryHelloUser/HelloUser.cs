using System;

namespace ClassLibraryHelloUser
{
    public class HelloUser
    {
        private string userName;

        public HelloUser(string userName)
        {
            this.userName = userName;
        }

        public string Greetings => $"{DateTime.Now.ToString("HH:mm.ss")} Hello {this.userName}";
    }
}
