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
            Console.WriteLine($"Hello {userName}");
        }
    }
}
