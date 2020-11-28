using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Validation
    {
        //contants
        public const string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public const string MOBILENUMBER_PATTERN = "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public const string EMAIL_PATTERN= "^[a-zA-Z0-9+_-]+(?:\\.[a-zA-Z0-9_-]+)*@[a-zA-Z0-9]+(?:\\.[a-zA-Z]{2,}){1,2}$";
        public const string PASSWORD_PATTERN= "^(?=.*[0-9])" + "(?=.*[a-z])(?=.*[A-Z])" + "(?=.*[@#$%^&+=])" + "(?=\\S+$).{8,}$";
        

        
        /// <summary>
        /// validates the user firstname and  lastname
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>

        public bool Name_Validation(string name)
        {
            bool result = Regex.IsMatch(name, NAME_PATTERN);
            try
            {
                if (result == false)
                {
                    
                    if (name.Length < 3)
                        throw new UserRegistrationException("Name cantains atleast 3 characters", 
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_LESSTHAN_MINUMUM_LENGTH);
                    if (name.Any(char.IsDigit))
                        throw new UserRegistrationException("Name should not contain numerics", 
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_NUMBER);
                    if (name.Equals(string.Empty))
                        throw new UserRegistrationException("Name should not be empty", 
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_EMPTY);
                    if (!char.IsUpper(name[0]))
                        throw new UserRegistrationException("Name should starts with uppercase", 
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_LOWERCASE);
                    if (name.Any(char.IsLetterOrDigit))
                        throw new UserRegistrationException("Name should not contain special character", 
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_SPECIAL_CHARACTER);
                }
            }
            /*catch (StackOverflowException userException)
            {
                Console.WriteLine(userException.Message);
            }*/
            catch (UserRegistrationException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return result;
        }

        /// <summary>
        /// validates the user mobilenumber
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>

        public bool Number_Validation(string number)
        {
            bool result = Regex.IsMatch(number, MOBILENUMBER_PATTERN);
            try
            {
                if (number.Length == 10)
                    throw new UserRegistrationException("Country code is missing in mobilenumber",
                                                            UserRegistrationException.ExceptionType.USER_NOTENTERED_COUNTRYCODE);
                if (number.Length >13)
                    throw new UserRegistrationException("Mobile Number should be exactly 10 numerics", 
                                                            UserRegistrationException.ExceptionType.USER_ENTERED_LESSTHAN_MINUMUM_LENGTH);
                if (number.Equals(string.Empty))
                    throw new UserRegistrationException("Mobile Number should not be empty", 
                                                            UserRegistrationException.ExceptionType.USER_ENTERED_EMPTY);
                if (!number.Any(char.IsWhiteSpace))
                    throw new UserRegistrationException("There must be space between countrycode and number", 
                                                            UserRegistrationException.ExceptionType.USER_NOTENTERED_SPACE_INNUMBER);
                if (number.Any(char.IsLetter))
                    throw new UserRegistrationException("Alphabets not allowed in mobilenumber", 
                                                            UserRegistrationException.ExceptionType.USER_ENTERED_ALPHABET);
                if (number.Any(char.IsLetterOrDigit))
                    throw new UserRegistrationException("Special characters not allowed in mobile number",
                                                            UserRegistrationException.ExceptionType.USER_ENTERED_SPECIAL_CHARACTER);
                /*if (number.IndexOf[4])
                    throw new UserRegistrationException("Mobile Number starts with greater than 6", 
                                                            UserRegistrationException.ExceptionType.INVALID_NUMBER);*/
            }
            catch (UserRegistrationException userException)
            {
                Console.WriteLine(userException.Message);
            }
            return result;
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
            bool result = Regex.IsMatch(password, PASSWORD_PATTERN);
            try
            {
                if (result == false)
                {
                    if (!password.Any(char.IsLetterOrDigit))
                        throw new UserRegistrationException("Password should contain Special character", 
                                                                    UserRegistrationException.ExceptionType.USER_NOTENTERED_SPCLCHAR);
                    if (password.Length < 8)
                        throw new UserRegistrationException("password must contains minum 8 characters", 
                                                                    UserRegistrationException.ExceptionType.USER_ENTERED_LESSTHAN_MINUMUM_LENGTH);
                    if (!password.Any(char.IsDigit))
                        throw new UserRegistrationException("Password should contain atleast one numeric", 
                                                                    UserRegistrationException.ExceptionType.USER_NOTENTERED_NUMERIC);
                    if (!password.Any(char.IsLower))
                        throw new UserRegistrationException("password should contain alleast one lowercase", 
                                                                    UserRegistrationException.ExceptionType.USER_NOTENTERED_LOWERCASE);
                    if (!password.Any(char.IsUpper))
                        throw new UserRegistrationException("password should contain alteast one uppercase", 
                                                                    UserRegistrationException.ExceptionType.USER_NOTENTERED_UPPERCASE);
                    if (password.Any(char.IsWhiteSpace))
                        throw new UserRegistrationException("password should not contain spaces", 
                                                                    UserRegistrationException.ExceptionType.USER_ENTERED_SPACE);
                    if (password.Equals(string.Empty))
                        throw new UserRegistrationException("password should not be empty", 
                                                                    UserRegistrationException.ExceptionType.USER_ENTERED_EMPTY);
                }
            }catch(UserRegistrationException userException)
            {
                Console.WriteLine(userException.Message);
            }
            return result;
        }
    }
}
