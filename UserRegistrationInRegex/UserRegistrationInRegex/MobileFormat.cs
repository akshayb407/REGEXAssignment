using System;
using System.Text.RegularExpressions;

namespace UserRegistrationInRegex
{
    internal class MobileFormat
    {
        public static string REGEX_MobileNo = "^[0-9]{1,3}[ ][6789][0-9]{9}$"; // 91 9919819801

        public bool ValidateMobileNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, REGEX_MobileNo);
        }
    }
}
