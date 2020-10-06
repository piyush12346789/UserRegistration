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
            Console.WriteLine("Enter your last name : ");
            string lastName = Console.ReadLine();
            bool lNameResult = validateUserRegistration.ValidateLastName(lastName);
            validateUserRegistration.PrintResult(lNameResult);
        }
    }
}
