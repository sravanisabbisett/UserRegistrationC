using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UserRegistration
{
    class UserValidationTest
    {
        public void Display(string firstName,string lastName, string number, string email, string password)
        {
            Console.WriteLine("Employee class validation");
            UserDetails userDetails = new UserDetails();

            userDetails.Name = firstName;
            userDetails.Name = lastName;
            userDetails.Number = number;
            userDetails.Email = email;
            userDetails.Password = password;
            
            

            ValidationContext context = new ValidationContext(userDetails, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(userDetails, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("MemberName:{0}", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("ErrorMsg::{0}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("FirstName:" + userDetails.Name + "\n" + "LastName:" + userDetails.Name + "\n" + "MobileNumber:" + userDetails.Number + "\n" + "Email:" + userDetails.Email+"\n"+"Password:"+userDetails.Password);
            }

        }
    }
}
