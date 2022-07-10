using System;

namespace UserRegistrationInRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Regular Expression Program");

            ///First Name
            FirstName firstName = new FirstName();
            Console.WriteLine("Enter First Nmae");
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


        }
    }
}