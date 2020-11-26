using System;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user Registration problem");
            Validation validation = new Validation();
            Console.WriteLine("Enter your Firstname");
            string firstName = Console.ReadLine();
            Console.WriteLine(validation.Name_Validation(firstName));
            Console.WriteLine("Enter your Lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine(validation.Name_Validation(lastName));
            Console.WriteLine("Enter your Mobilenumber");
            string number = Console.ReadLine();
            Console.WriteLine(validation.Number_Validation(number));
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            Console.WriteLine(validation.Email_validation(email));
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine(validation.Password_Validation(password));
            Console.ReadKey();
        }
    }
}
