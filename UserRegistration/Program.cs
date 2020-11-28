﻿using System;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user Registration problem");
            Validation validation = new Validation();
            bool FirstNameresult, LastNameResult, NumberResult, EmailResult, PasswordResult;
            FirstNameresult = LastNameResult = NumberResult = EmailResult = PasswordResult = false;
            while (!FirstNameresult)
            {
                Console.WriteLine("Enter your Firstname");
                string firstName = Console.ReadLine();
                bool FirstNmaeValidation = validation.Name_Validation(firstName);
                FirstNameresult = FirstNmaeValidation;
            }
            while (!LastNameResult)
            { 
                Console.WriteLine("Enter your Lastname");
                string lastName = Console.ReadLine();
                bool LastNameValidation=validation.Name_Validation(lastName);
                LastNameResult = LastNameValidation;
            }
            while (!NumberResult)
            {
                Console.WriteLine("Enter your Mobilenumber");
                string number = Console.ReadLine();
                bool NumberValidation=validation.Number_Validation(number);
                NumberResult = NumberValidation;
            }
            while (!EmailResult)
            {
                Console.WriteLine("Enter your email");
                string email = Console.ReadLine();
                bool EmailValidation=validation.Email_validation(email);
                EmailResult = EmailValidation;
            }
            while (!PasswordResult)
            {
                Console.WriteLine("Enter your password");
                string password = Console.ReadLine();
                bool PasswordValidation=validation.Password_Validation(password);
                PasswordResult = PasswordValidation;
            }
            Console.ReadKey();
        }
    }
}
