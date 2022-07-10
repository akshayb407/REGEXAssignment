using System;
using System.Text.RegularExpressions;

namespace UserRegistrationInRegex
{
    internal class LastName
    {
        public static string LAST_NAME_REGEX = "^[A-Z]{1}[a-z]{2,}$";

        public bool ValidateLastName(string lName)
        {
            return Regex.IsMatch(lName, LAST_NAME_REGEX);
        }
    }
}
