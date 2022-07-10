using System;
using System.Text.RegularExpressions;

namespace UserRegistrationInRegex
{
    internal class Password1Minimum8Character
    {
<<<<<<< HEAD:UserRegistrationInRegex/UserRegistrationInRegex/Password1Min8Character.cs

        public static string REGEX_Password1 = "^[A-Z a-z]{8,}$"; //akshayab

=======
        public static string REGEX_Password1 = "^[A-Z a-z]{8,}$";//akshayab
>>>>>>> UC6:UserRegistrationInRegex/UserRegistrationInRegex/Password1Minimum8Character.cs
        public bool ValidatePassword1(string password)
        {
            return Regex.IsMatch(password, REGEX_Password1);
        }
    }
}
