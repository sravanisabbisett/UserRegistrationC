using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Pattern
    {
        public string name, number, email, password;
        //contants
        public const string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public const string MOBILENUMBER_PATTERN = "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public const string EMAIL_PATTERN = "^[a-zA-Z0-9+_-]+(?:\\.[a-zA-Z0-9_-]+)*@[a-zA-Z0-9]+(?:\\.[a-zA-Z]{2,}){1,2}$";
        public const string PASSWORD_PATTERN = "^(?=.*[0-9])" + "(?=.*[a-z])(?=.*[A-Z])" + "(?=.*[@#$%^&+=])" + "(?=\\S+$).{8,}$";


        public Pattern()
        {

        }
        public Pattern(string name,string number,string email,string password)
        {
            this.name = name;
            this.number = number;
            this.email = email;
            this.password = password;
        }

        /// <summary>
        /// validates the user firstname and  lastname
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>

        public bool Name_Validation()
        {
            try
            {
                return Regex.IsMatch(this.name, NAME_PATTERN) ? true : false;
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException("Input is in valid", UserRegistrationException.ExceptionType.INVALID_FORMAT);
            }
            
        }

        /// <summary>
        /// validates the user mobilenumber
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>

        public bool Number_Validation()
        {
           
            try
            {
                return Regex.IsMatch(this.number, MOBILENUMBER_PATTERN) ? true : false;
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException("Input is in valid", UserRegistrationException.ExceptionType.INVALID_FORMAT);
            }
        }

        /// <summary>
        /// validates the user emailId
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>

        public bool Email_validation()
        { 
            try
            {
                return Regex.IsMatch(this.email, EMAIL_PATTERN) ? true : false;
            }
            catch (ArgumentNullException)
            {
                throw new UserRegistrationException("Input is in valid", UserRegistrationException.ExceptionType.INVALID_FORMAT);
            }
        }

        /// <summary>
        /// Passwords the validation.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool Password_Validation()
        {
            try
            {
                return Regex.IsMatch(this.password, PASSWORD_PATTERN) ? true : false;
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException("Input is in valid", UserRegistrationException.ExceptionType.INVALID_FORMAT);
            }
        }
    }
}
