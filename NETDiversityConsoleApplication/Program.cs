using ClassLibraryHelloUser;
using System;

namespace NETDiversityConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string userName;
            userName = Console.ReadLine();

            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException(nameof(userName));
            }

            Console.WriteLine("What's your email?");
            string userEmail;
            userEmail = Console.ReadLine();

            if (string.IsNullOrEmpty(userEmail))
            {
                throw new ArgumentException(nameof(userEmail));
            }

            HelloUser helloUser = new(userName, userEmail);
            Console.WriteLine(helloUser.Greetings);
        }
    }
}
