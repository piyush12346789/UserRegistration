using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration
{
    class ValidateUserRegistration
    {
        private static string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        private static string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFirstName(string FN)
        {
            return Regex.IsMatch(FN, Regex_FirstName);
        }
        public bool ValidateLastName(string LN)
        {
            return Regex.IsMatch(LN, Regex_LastName);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
    }
}