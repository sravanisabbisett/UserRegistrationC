using System;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user Registration problem");
            UserValidationTest userValidation = new UserValidationTest();
            userValidation.Display("Sravani","Sabbisetti","91 8712443377","sravani@gmail.com","Shanu12@");
            userValidation.Display("Sr", "Sa", "8712443377", "sravani@.gmail.com", "shanu12");
            Console.ReadKey();
        }
    }
}
