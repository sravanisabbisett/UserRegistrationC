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
        public const string EMAIL_PATTERN= "^[a-zA-Z0-9+_-]+(?:\\.[a-zA-Z0-9_-]+)*@[a-zA-Z0-9]+(?:\\.[a-zA-Z]{2,}){1,2}$";
        public const string PASSWORD_PATTERN= "^(?=.*[0-9])" + "^(?=.*[a - z])(?=.*[A - Z]).{8,}$";

        /// <summary>
        /// validates the user firstname and  lastname
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>

        public bool FirstName_Validation(string name)
        {
            if (Regex.IsMatch(name, NAME_PATTERN))
               return true;
            return false;
        }

        /// <summary>
        /// validates the user mobilenumber
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>

        public bool Number_Validation(string number)
        {
            if (Regex.IsMatch(number, MOBILENUMBER_PATTERN))
                return true;
            return false;
        }

        /// <summary>
        /// validates the user emailId
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>

        public bool Email_validation(string email)
        {
            if (Regex.IsMatch(email, EMAIL_PATTERN))
                return true;
            return false;
        }

        /// <summary>
        /// Passwords the validation.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Password_Validation(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_PATTERN))
                return true;
            return false;
        }
    }
}
