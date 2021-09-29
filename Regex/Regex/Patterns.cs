using System;
using System.Text.RegularExpressions;

namespace Regex
{
    public class Patterns
    {
        public static string REGEX_PINCODE = "^[1-9][0-9](5)$"; //400000

        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE);
        }
    }
}
