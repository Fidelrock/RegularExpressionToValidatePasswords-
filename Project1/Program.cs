using System;
using System.Text.RegularExpressions;

namespace PasswordValidation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Creating a regular expression pattern that checks if a password meets the requirements
            string pattern1 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!#@_$])[a-zA-Z0-9!#@_$]{8,}$";

            // Sample password to validate
            string inputToValidate = "Fidelrock@1234";

            // Validate the password using the regular expression
            if (Regex.IsMatch(inputToValidate, pattern1))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.ReadKey();
        }
    }
}
