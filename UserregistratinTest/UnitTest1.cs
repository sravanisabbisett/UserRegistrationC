using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserregistratinTest
{
    [TestClass]
    public class UnitTest1
    {
        private Validation validation;

        public UnitTest1()
        {
            validation = new Validation();
        }

        /// <summary>
        /// Givens the first name with valid should return true.
        /// </summary>
        [TestMethod]

        public void GivenFirstName_WithValid_shouldReturnTrue()
        {
            bool result=validation.Name_Validation("Sravani");
            Assert.IsTrue(result);
        }
        
        /// <summary>
        /// Givens the first name with minimum length should return true.
        /// </summary>

        [TestMethod]
        public void GivenFirstName_WithMinLength_shouldReturnTrue()
        {
            bool result = validation.Name_Validation("Sra");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Givens the first name with less than minimum length should return false.
        /// </summary>

        [TestMethod]
        public void GivenFirstName_WithLessThanMinLength_shouldReturnFalse()
        {
            try
            {
                bool result = validation.Name_Validation("Sr");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Name cantains atleast 3 characters", userException.Message);
            }
        }

        /// <summary>
        /// Givens the first name with numeric should return false.
        /// </summary>

        [TestMethod]
        public void GivenFirstName_WithNumeric_shouldReturnFalse()
        {
            try
            {
                bool result = validation.Name_Validation("Sravani2");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Name should not contain numerics", userException.Message);
            }
        }

        /// <summary>
        /// Givens the first name with special character should return false.
        /// </summary>

        [TestMethod]
        public void GivenFirstName_WithSpecialCharacter_shouldReturnFalse()
        {
            try
            {
                bool result = validation.Name_Validation("Sravani@");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Name should not contain special character", userException.Message);
            }
        }

        /// <summary>
        /// Givens the first name with out first letter upper case should return false.
        /// </summary>

        [TestMethod]
        public void GivenFirstName_WithOutFirstLetterUpperCase_shouldReturnFalse()
        {
            try
            {
                bool result = validation.Name_Validation("sravani");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Name should starts with uppercase", userException.Message);
            }
        }

        /// <summary>
        /// Givens the first name with empty should return false.
        /// </summary>

        [TestMethod]
        public void GivenFirstName_WithEmpty_shouldReturnFalse()
        {
            try
            {
                bool result = validation.Name_Validation("");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Name should not be empty", userException.Message);
            }
        }

        /// <summary>
        /// Givens the last name with valid should return true.
        /// </summary>

        [TestMethod]
        public void GivenLastName_WithValid_shouldReturnTrue()
        {
            bool result = validation.Name_Validation("Sabbisetti");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Givens the last name with minimum length should return true.
        /// </summary>

        [TestMethod]
        public void GivenLastName_WithMinLength_shouldReturnTrue()
        {
            bool result = validation.Name_Validation("Sab");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Givens the last name with less than minimum length should return false.
        /// </summary>

        [TestMethod]
        public void GivenLastName_WithLessThanMinLength_shouldReturnFalse()
        {
            try
            {
                bool result = validation.Name_Validation("Sa");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Name cantains atleast 3 characters", userException.Message);
            }
        }

        /// <summary>
        /// Givens the last name with numeric should return false.
        /// </summary>

        [TestMethod]
        public void GivenLastName_WithNumeric_shouldReturnFalse()
        {
            try
            {
                bool result = validation.Name_Validation("Sabbisetti1");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Name should not contain numerics", userException.Message);
            }
        }

        /// <summary>
        /// Givens the last name with special character should return false.
        /// </summary>

        [TestMethod]
        public void GivenLastName_WithSpecialCharacter_shouldReturnFalse()
        {
            try
            {
                bool result = validation.Name_Validation("Sabbisetti@");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Name should not contain special character", userException.Message);
            }
        }

        /// <summary>
        /// Givens the last name with out first letter upper case should return false.
        /// </summary>

        [TestMethod]
        public void GivenLastName_WithOutFirstLetterUpperCase_shouldReturnFalse()
        {
            try
            {
                bool result = validation.Name_Validation("sabbisetti");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Name should starts with uppercase", userException.Message);
            }
        }

        /// <summary>
        /// Givens the last name with empty should return false.
        /// </summary>

        [TestMethod]
        public void GivenLastName_WithEmpty_shouldReturnFalse()
        {
            try
            {
                bool result = validation.Name_Validation("");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Name should not be empty", userException.Message);
            }
        }

        /// <summary>
        /// Givens the mobile number with proper should return false.
        /// </summary>

        [TestMethod]
        public void GivenMobileNumber_WithProper_ShouldReturnFalse()
        {
            bool result = validation.Number_Validation("91 8712443377");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Givens the mobile number with out country code should return false.
        /// </summary>

        [TestMethod]
        public void GivenMobileNumber_WithOutCountryCode_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Number_Validation("8712443377");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Country code is missing in mobilenumber", userException.Message);
            }
        }

        /// <summary>
        /// Givens the mobile number with out space between country code and number should return false.
        /// </summary>

        [TestMethod]
        public void GivenMobileNumber_WithOutSpaceBetweenCountryCodeAndNumber_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Number_Validation("918712443377");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("There must be space between countrycode and number", userException.Message);
            }
        }

        /// <summary>
        /// Givens the mobile number with invalid length should return false.
        /// </summary>

        [TestMethod]
        public void GivenMobileNumber_WithInvalidLength_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Number_Validation("91 871244337");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Mobile Number should be exactly 10 numerics",userException.Message);
            }
        }

        /// <summary>
        /// Givens the mobile number with starting less than numeric6 should return false.
        /// </summary>

        [TestMethod]
        public void GivenMobileNumber_WithStartingLessThanNumeric6_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Number_Validation("91 5712443377");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Mobile Number starts with greater than 6", userException.Message);
            }
        }

        /// <summary>
        /// Givens the mobile number with empty should return false.
        /// </summary>
        
        [TestMethod]
        public void GivenMobileNumber_WithEmpty_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Number_Validation("");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Mobile Number should not be empty", userException.Message);
            }
        }

        /// <summary>
        /// Givens the mobile mumber with alphabet should return false.
        /// </summary>

        [TestMethod]
        public void GivenMobileMumber_WithAlphabet_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Number_Validation("91 a871244337");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Alphabets not allowed in mobilenumber", userException.Message);
            }
        }

        /// <summary>
        /// Givens the mobile number with special character should return false.
        /// </summary>

        [TestMethod]
        public void GivenMobileNumber_WithSpecialCharacter_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Number_Validation("91 @123456789");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Special characters not allowed in mobile number", userException.Message);
            }
        }

        /// <summary>
        /// Givens the password with valid should return true.
        /// </summary>

        [TestMethod]
        public void GivenPassword_WithValid_ShouldReturnTrue()
        {
            bool result = validation.Password_Validation("Shanu12@");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Givens the password with starting lower case should return true.
        /// </summary>

        [TestMethod]
        public void GivenPassword_WithStartingLowerCase_ShouldReturnTrue()
        {
            bool result = validation.Password_Validation("shanU12@");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Givens the password with starting numeric should return true.
        /// </summary>

        [TestMethod]
        public void GivenPassword_WithStartingNumeric_ShouldReturnTrue()
        {
            bool result = validation.Password_Validation("1Shanu1@");
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Givens the password with less than minimum length should return false.
        /// </summary>

        [TestMethod]
        public void GivenPassword_WithLessThanMinimumLength_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Password_Validation("Shanu1@");
            }
            catch (UserRegistrationException userException){
                Assert.AreEqual("password must contains minum 8 characters", userException.Message);
            }
        }

        /// <summary>
        /// Givens the password with out upper case should return false.
        /// </summary>

        [TestMethod]
        public void GivenPassword_WithOutUpperCase_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Password_Validation("shanu12@");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("password should contain alteast one uppercase", userException.Message);
            }
        }

        /// <summary>
        /// Givens the password with out lower case should return false.
        /// </summary>

        [TestMethod]
        public void GivenPassword_WithOutLowerCase_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Password_Validation("SHANU12@");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("password should contain alleast one lowercase",userException.Message);
            }
        }

        /// <summary>
        /// Givens the password with out numeric should return false.
        /// </summary>

        [TestMethod]
        public void GivenPassword_WithOutNumeric_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Password_Validation("Sravani@");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Password should contain atleast one numeric", userException.Message);
            }
        }

        /// <summary>
        /// Givens the password with out special character should return false.
        /// </summary>

        [TestMethod]
        public void GivenPassword_WithOutSpecialCharacter_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Password_Validation("Shanu123");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("Password should contain Special character", userException.Message);
            }
        }

        /// <summary>
        /// Givens the password with empty should return false.
        /// </summary>

        [TestMethod]
        public void GivenPassword_WithEmpty_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Password_Validation("");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("password should not be empty",userException.Message);
            }
        }

        /// <summary>
        /// Givens the password with spaces should return false.
        /// </summary>

        [TestMethod]
        public void GivenPassword_WithSpaces_ShouldReturnFalse()
        {
            try
            {
                bool result = validation.Password_Validation("Shanu 12@");
            }
            catch (UserRegistrationException userException)
            {
                Assert.AreEqual("password should not contain spaces", userException.Message);
            }
        }

        /// <summary>
        /// Parameterised testcase takes multiple inputs at atime and return result
        /// </summary>
        /// <param name="email">The email.</param>

        [TestMethod]
            [DataRow("abc@yahoo.com")]
            [DataRow("abc-100@yahoo.com")]
            [DataRow("abc.100@yahoo.com")]
            [DataRow("abc111@abc.com")]
            [DataRow("abc-100@abc.net")]
            [DataRow("abc.100@abc.com.au")]
            [DataRow("abc@1.com")]
            [DataRow("abc@gmail.com.com")]
            [DataRow("abc+100@gmail.com")]
        public void GivenEmail_ValidInMultiple_ShouldReturnAsPerTrue(string email)
        {
            bool result = validation.Email_validation(email);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Parameterised testcase takes multiple inputs at atime and return result
        /// </summary>
        /// <param name="email">The email.</param>

        [TestMethod]
            [DataRow("abc.com")]
            [DataRow("abc@.com.my")]
            [DataRow("abc123@gmail.a")]
            [DataRow("abc123@.com")]
            [DataRow("abc123@.com.com")]
            [DataRow(".abc@abc.com")]
            [DataRow("abc@%*.com")]
            [DataRow("abc()*@gmail.com")]
            [DataRow("abc..2002@gmail.com")]
            [DataRow("abc.@gmail.com")]
            [DataRow("abc@gmail.com.1a")]
            [DataRow("abc@gmail.com.aa.au")]
            [DataRow("")]
        public void GivenEmail_InValidMultiple_ShouldReturnAsPerFalse(string email)
        {
            bool result = validation.Email_validation(email);
            Assert.IsFalse(result);
        }
    }
}
