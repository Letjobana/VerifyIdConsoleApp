using System;
using System.Text.RegularExpressions;

namespace IdentityVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            string identity;
            Console.WriteLine("Enter you Identity Number");
            identity = Console.ReadLine();
            ValidateUserId(identity);
            Console.ReadLine();
        }
        public static void ValidateUserId(string userId)
        {
            if (userId.Length != 13 || Regex.IsMatch(userId, "[^0-9]"))
                Console.WriteLine("Please enter a valid Id, A valid Id should contain 13 numbers");
            else
                Console.WriteLine("Thank you,your Id is Valid");
        }
    }
}
