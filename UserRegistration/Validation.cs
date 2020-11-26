using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validation
    {
        public const string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public const string MOBILENUMBER_PATTERN = "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$";

        public bool FirstName_Validation(string name)
        {
            if (Regex.IsMatch(name, NAME_PATTERN))
               return true;
            return false;
        }

        public bool Number_Validation(string number)
        {
            if (Regex.IsMatch(number, MOBILENUMBER_PATTERN))
                return true;
            return false;
        }
    }
}
