using System;
using System.Text.RegularExpressions;

namespace UserRegistrationInRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Regular Expression Program");

            ///First Name
            FirstName firstName = new FirstName();
            Console.WriteLine("Enter First Name");
            string ValidateFirstName = Console.ReadLine();
          
            if (firstName.ValidateFirstName("Akshay"))
            {

                Console.WriteLine("The First Name is Valid");
            }
            else
                Console.WriteLine("The First Name is Invalid");

            ///last Name
            Console.WriteLine("Enter Last Name");
            string LastName = Console.ReadLine();
            LastName lastName = new LastName();
            if (lastName.ValidateLastName("Bhagwat"))
            {
                Console.WriteLine("The Last Name is Valid");
            }
            else
                Console.WriteLine("The Last Name is Invalid");

            ///Valid Email
            Console.WriteLine("Enter Email");
            string ValidEmail = Console.ReadLine();
            ValidEmail checkEmail = new ValidEmail();
            if (checkEmail.ValidateEMail("abc.xyz@bl.co.in"))
            {
                Console.WriteLine("The Email is Valid");
            }
            else
                Console.WriteLine("The Email is Invalid");

            ///Mobile Format
            Console.WriteLine("Enter Mobile Number");
            string MobileFormat = Console.ReadLine();
            MobileFormat mobileFormate = new MobileFormat();
            if (mobileFormate.ValidateMobileNo("91 9919819801"))
            {
                Console.WriteLine("The Mobile Number is Valid");
            }
            else
                Console.WriteLine("The Mobile Number is Invalid");

            ///Password 1 Minimum 8 character
            Console.WriteLine("Enter Password");
            string Password1Min8Character = Console.ReadLine();

            Password1Min8Character Min8Char = new Password1Min8Character();

            if (Min8Char.ValidatePassword1("Akshayab"))
            {
                Console.WriteLine("The Password1 is Valid");
            }
            else
                Console.WriteLine("The Password1 is Invalid");

            
        }
    }
}