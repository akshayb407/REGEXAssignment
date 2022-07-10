using System;
using System.Text.RegularExpressions;

namespace UserRegistrationInRegex
{
    internal class Password1Minimum8Character
    {
        public static string REGEX_Password1 = "^[A-Z a-z]{8,}$";//akshayab
        public bool ValidatePassword1(string password)
        {
            return Regex.IsMatch(password, REGEX_Password1);
        }
    }
}
