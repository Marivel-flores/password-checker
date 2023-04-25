using System;
using static System.Formats.Asn1.AsnWriter;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        { 

        int minLength = 8;
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        string digits = "1234567890";
        string specialChars = "!@#$%^&*";

        Console.WriteLine("***Welcome to the Password Checker. Please enter a password: ");
        string userPassword = Console.ReadLine();

        int score = 0;
        int userPasswordCount = userPassword.Length;

            if (userPasswordCount >= minLength)
            {
                score++;
            } if (Tools.Contains(userPassword, uppercase)) 
            {
                score++;
            }
            if (Tools.Contains(userPassword, lowercase))
            {
                score++;
            }
            if (Tools.Contains(userPassword, digits))
            {
                score++;
            }
            if (Tools.Contains(userPassword, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Extreme strongly password");
                    break;
                case 3:
                    Console.WriteLine("Strong password");
                    break;
                case 2:
                    Console.WriteLine("Medium password");
                    break;
                case 1:
                    Console.WriteLine("Weak password");
                    break;
                default:
                    Console.WriteLine("Password does not meet any of the criteria.");
                    break;
            }
        }
  
    }
}

