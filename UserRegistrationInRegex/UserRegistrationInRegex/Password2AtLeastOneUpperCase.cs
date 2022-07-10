using System;
using System.Text.RegularExpressions;

namespace UserRegistrationInRegex
{
    internal class Password2AtLeastOneUpperCase
    {
        public static string REGEX_Password2 = "^[A-Z]{1}[A-Z a-z]{7,}$"; //AkshayBhagwat

        public bool ValidatePassword2(string password)
        {
            return Regex.IsMatch(password, REGEX_Password2);
        }

    }
}
