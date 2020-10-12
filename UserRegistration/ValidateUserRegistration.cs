using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistration
{
    public class ValidateUserRegistration
    {
        private List<string> sampleMails = new List<string>()
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };
        private static string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        private static string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        private static string Regex_Email = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        private static string Regex_MobileNo = "^[1-9]{1}[0-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        private static string Regex_Password = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&+-.]*[!@#$%&+-.][^!@#$%&+-.]*$)[\\S]{8,}$";
        private static string Regex_Email2 = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";        
        public bool ValidateFirstName(string FN)
        {
            
            if(Regex.IsMatch(FN, Regex_FirstName))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_FIRST_NAME, "Invalid first name.");
            }
        }
        public bool ValidateLastName(string LN)
        {
            if (Regex.IsMatch(LN, Regex_LastName))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_LAST_NAME, "Invalid last name.");
            }
        }
        public bool ValidateEmail(string Email)
        {
            if(Regex.IsMatch(Email, Regex_Email))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_EMAIL, "Invalid email address.");
            }
        }
        public bool ValidateMobileNo(string MobileNo)
        {
            if(Regex.IsMatch(MobileNo, Regex_MobileNo))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_MOBILENO, "Invalid mobile no.");
            }
        }
        public bool ValidatePassword(string Password)
        {
            if(Regex.IsMatch(Password, Regex_Password))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_PASSWORD, "Invalid password.");
            }
        }
        public bool ValidateEmail2(string email)
        {
            if(Regex.IsMatch(email, Regex_Email2))
            {
                return true;
            }
            else
            {
                throw new URCustomException(URCustomException.ExceptionType.INVALID_EMAIL, "Invalid email address.");
            }
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
        public List<string> GetList()
        {
            return sampleMails;
        }
    }
}