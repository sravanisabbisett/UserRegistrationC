using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegistrationException :Exception
    {
        public enum ExceptionType
        {
            USER_ENTERED_LESSTHAN_MINUMUM_LENGTH,USER_ENTERED_SPECIAL_CHARACTER,USER_ENTERED_NUMBER,
            USER_ENTERED_LOWERCASE,USER_ENTERED_EMPTY,USER_NOTENTERED_SPCLCHAR,USER_NOTENTERED_NUMERIC,
            USER_NOTENTERED_LOWERCASE,USER_NOTENTERED_UPPERCASE,USER_ENTERED_SPACE,USER_ENTERED_ALPHABET,
            USER_NOTENTERED_SPACE_INNUMBER,USER_NOTENTERED_COUNTRYCODE,INVALID_NUMBER, NO_SUCH_FIELD,
            NULL_MESSAGE,INVALID_FORMAT
            
        }

        ExceptionType exceptionType;
        string message;

        public UserRegistrationException(string message,ExceptionType exceptionType) : base(message)
        {
            this.exceptionType = exceptionType;
            this.message = message;
        }
    }
}
