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
            Console.WriteLine("Enter your email : ");
            string eMail = Console.ReadLine();
            bool eMailResult = validateUserRegistration.ValidateEmail(eMail);
            validateUserRegistration.PrintResult(eMailResult);
            Console.WriteLine("Enter your mobile number : ");
            string mobileNo = Console.ReadLine();
            bool mobileNoResult = validateUserRegistration.ValidateMobileNo(mobileNo);
            validateUserRegistration.PrintResult(mobileNoResult);
        }
    }
}
