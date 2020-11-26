using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validation
    {
        public const string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        

        public bool FirstName_Validation(string name)
        {
            if (Regex.IsMatch(name, NAME_PATTERN))
               return true;
            return false;
        }
    }
}
