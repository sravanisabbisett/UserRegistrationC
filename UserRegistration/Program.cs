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
            Console.WriteLine(validation.FirstName_Validation(firstName));
            Console.WriteLine("Enter your Lastname");
            string lastName = Console.ReadLine();
            Console.WriteLine(validation.FirstName_Validation(lastName));
            Console.ReadKey();
        }
    }
}
