using System;
namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserRegistration validateUserRegistration = new ValidateUserRegistration();
            Console.WriteLine("Enter your first name : ");
            string firstName = Console.ReadLine();
            bool fNameResult = validateUserRegistration.ValidateFirstName(firstName);
            validateUserRegistration.PrintResult(fNameResult);
        }
    }
}
