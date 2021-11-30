using System.Text.RegularExpressions;

namespace ClassLibraryHelloUser
{
    internal static class Validator
    {
        internal static string ValidateData(string userName, string userEmail)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return "Fill your name!";
            }

            if (string.IsNullOrEmpty(userEmail))
            {
                return "Fill you email!";
            }

            if (!Regex.IsMatch(userName, "^[A-Za-zÀ-ú]+ [A-Za-zÀ-ú]+$"))
            {
                return "Incorrect name!";
            }

            if (!Regex.IsMatch(userEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
            {
                return "Incorrect email!";
            }

            return null;
        }
    }
}
