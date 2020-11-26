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

        
        [TestMethod]
        public void givenFirstName_WithValid_shouldReturnTrue()
        {
            bool result=validation.Name_Validation("Sravani");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenFirstName_WithMinLength_shouldReturnTrue()
        {
            bool result = validation.Name_Validation("Sra");
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void givenFirstName_WithLessThanMinLength_shouldReturnFalse()
        {
            bool result = validation.Name_Validation("Sr");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenFirstName_WithNumeric_shouldReturnFalse()
        {
            bool result = validation.Name_Validation("Sravani1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenFirstName_WithSpecialCharacter_shouldReturnFalse()
        {
            bool result = validation.Name_Validation("Sravani@");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenFirstName_WithOutFirstLetterUpperCase_shouldReturnFalse()
        {
            bool result = validation.Name_Validation("sravani");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenFirstName_WithEmpty_shouldReturnFalse()
        {
            bool result = validation.Name_Validation(" ");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WithValid_shouldReturnTrue()
        {
            bool result = validation.Name_Validation("Sabbisetti");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenLastName_WithMinLength_shouldReturnTrue()
        {
            bool result = validation.Name_Validation("Sab");
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void givenLastName_WithLessThanMinLength_shouldReturnFalse()
        {
            bool result = validation.Name_Validation("Sa");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WithNumeric_shouldReturnFalse()
        {
            bool result = validation.Name_Validation("Sabbisetti1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WithSpecialCharacter_shouldReturnFalse()
        {
            bool result = validation.Name_Validation("Sabbisetti@");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WithOutFirstLetterUpperCase_shouldReturnFalse()
        {
            bool result = validation.Name_Validation("sabbisetti");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenLastName_WithEmpty_shouldReturnFalse()
        {
            bool result = validation.Name_Validation(" ");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenMobileNumber_WithProper_ShouldReturnFalse()
        {
            bool result = validation.Number_Validation("91 8712443377");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenMobileNumber_WithOutCountryCode_ShouldReturnFalse()
        {
            bool result = validation.Number_Validation("8712443377");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenMobileNumber_WithOutSpaceBetweenCountryCodeAndNumber_ShouldReturnFalse()
        {
            bool result = validation.Number_Validation("918712443377");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenMobileNumber_WithInvalidLength_ShouldReturnFalse()
        {
            bool result = validation.Number_Validation("91871244337");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenMobileNumber_WithStartingLessThanNumeric6_ShouldReturnFalse()
        {
            bool result = validation.Number_Validation("91 571244337");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenMobileNumber_WithEmpty_ShouldReturnFalse()
        {
            bool result = validation.Number_Validation(" ");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithValid_ShouldReturnTrue()
        {
            bool result = validation.Password_Validation("Shanu12@");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenPassword_WithStartingLowerCase_ShouldReturnTrue()
        {
            bool result = validation.Password_Validation("shanU12@");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenPassword_WithStartingNumeric_ShouldReturnTrue()
        {
            bool result = validation.Password_Validation("1Shanu1@");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void givenPassword_WithLessThanMinimumLength_ShouldReturnFalse()
        {
            bool result = validation.Password_Validation("Shanu1@");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithOutUpperCase_ShouldReturnFalse()
        {
            bool result = validation.Password_Validation("shanu12@");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithOutLowerCase_ShouldReturnFalse()
        {
            bool result = validation.Password_Validation("SHANU12@");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithOutNumeric_ShouldReturnFalse()
        {
            bool result = validation.Password_Validation("Sravani@");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithOutSpecialCharacter_ShouldReturnFalse()
        {
            bool result = validation.Password_Validation("Shanu123");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void givenPassword_WithEmpty_ShouldReturnFalse()
        {
            bool result = validation.Password_Validation(" ");
            Assert.IsFalse(result);
        }

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
        public void givenEmail_ValidInMultiple_ShouldReturnAsPerTrue(string email)
        {
            bool result = validation.Email_validation(email);
            Assert.IsTrue(result);
        }

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
            [DataRow(" ")]
        public void givenEmail_InValidMultiple_ShouldReturnAsPerFalse(string email)
        {
            bool result = validation.Email_validation(email);
            Assert.IsFalse(result);
        }
    }
}
