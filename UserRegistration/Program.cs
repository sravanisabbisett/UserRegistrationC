using System;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user Registration problem");
            UserValidation userValidation = new UserValidation();
            userValidation.Display("Sravani","Sabbisetti","91 8712443377","sravani@gmail.com","Shanu12@");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Checking for invalid details");
            userValidation.Display("sra", "Sa", "8712443377", "sravani@.gmail.com", "shanu12");
            Console.ReadKey();
        }
    }
}
