using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class LambdaValidation
    {
        public const string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public const string MOBILENUMBER_PATTERN = "^[0-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public const string EMAIL_PATTERN = "^[a-zA-Z0-9+_-]+(?:\\.[a-zA-Z0-9_-]+)*@[a-zA-Z0-9]+(?:\\.[a-zA-Z]{2,}){1,2}$";
        public const string PASSWORD_PATTERN = "^(?=.*[0-9])" + "(?=.*[a-z])(?=.*[A-Z])" + "(?=.*[@#$%^&+=])" + "(?=\\S+$).{8,}$";

        public bool ValidateFirstName(string name) => (Regex.IsMatch(name, NAME_PATTERN));
        public bool NumberValidation(string number) => (Regex.IsMatch(number, MOBILENUMBER_PATTERN));
        public bool PasswordValidation(string password) => (Regex.IsMatch(password, PASSWORD_PATTERN));
        public bool EmailValidation(string email) => (Regex.IsMatch(email, EMAIL_PATTERN));

        /// <summary>
        /// Lambdas the name of the validation.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public bool LambdaValidationName(string name)
        {
            bool result = ValidateFirstName(name);
            try
            {
                if (result == false)
                {
                    if (name.Equals(string.Empty))
                        throw new UserRegistrationException("Name should not be empty",
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_EMPTY);
                    if (name.Length < 3)
                        throw new UserRegistrationException("Name cantains atleast 3 characters",
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_LESSTHAN_MINUMUM_LENGTH);
                    if (name.Any(char.IsDigit))
                        throw new UserRegistrationException("Name should not contain numerics",
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_NUMBER);
                    if (!char.IsUpper(name[0]))
                        throw new UserRegistrationException("Name should starts with uppercase",
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_LOWERCASE);
                    if (name.Any(char.IsLetterOrDigit))
                        throw new UserRegistrationException("Name should not contain special character",
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_SPECIAL_CHARACTER);
                }
            }
            catch (UserRegistrationException exception)
            {
                throw exception;
            }
            return result;
        }


        /// <summary>
        /// Lambdas the number validation.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        public bool LambdaNumberValidation(string number)
        {
            bool result = NumberValidation(number);
            double indexOfNumber = 0.0;
            char[] index = number.ToCharArray();
            if (number.Length > 0)
            {
                indexOfNumber = char.GetNumericValue(index[3]);
            }
            try
            {
                if (result == false)
                {
                    if (number.Equals(string.Empty))
                        throw new UserRegistrationException("Mobile Number should not be empty",
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_EMPTY);
                    if (number.Length == 10)
                        throw new UserRegistrationException("Country code is missing in mobilenumber",
                                                                UserRegistrationException.ExceptionType.USER_NOTENTERED_COUNTRYCODE);
                    if (!number.Any(char.IsWhiteSpace))
                        throw new UserRegistrationException("There must be space between countrycode and number",
                                                                UserRegistrationException.ExceptionType.USER_NOTENTERED_SPACE_INNUMBER);
                    if (number.Length < 13)
                        throw new UserRegistrationException("Mobile Number should be exactly 10 numerics",
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_LESSTHAN_MINUMUM_LENGTH);

                    if (number.Any(char.IsLetter))
                        throw new UserRegistrationException("Alphabets not allowed in mobilenumber",
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_ALPHABET);
                    if (indexOfNumber < 6)
                        throw new UserRegistrationException("Mobile Number starts with greater than 6",
                                                                 UserRegistrationException.ExceptionType.INVALID_NUMBER);
                    if (number.Any(char.IsLetterOrDigit))
                        throw new UserRegistrationException("Special characters not allowed in mobile number",
                                                                UserRegistrationException.ExceptionType.USER_ENTERED_SPECIAL_CHARACTER);
                }
            }
            catch (UserRegistrationException userException)
            {
                throw userException;
            }
            return result;
        }

        /// <summary>
        /// Lambdas the password validation.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool LambdaPasswordValidation(string password)
        {
            bool result = PasswordValidation(password);
            try
            {
                if (result == false)
                {
                    if (password.Equals(string.Empty))
                        throw new UserRegistrationException("password should not be empty",
                                                                    UserRegistrationException.ExceptionType.USER_ENTERED_EMPTY);
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

                }
            }
            catch (UserRegistrationException userException)
            {
                throw userException;
            }
            return result;
        }
    }
}
