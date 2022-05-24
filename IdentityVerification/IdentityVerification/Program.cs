using System;
using System.Globalization;
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
            GetDateOfBirth(userId);

        }
        public static void GetDateOfBirth(string birthDay)
        {
            DateTime dt;
            var dateOfBirth = birthDay.Substring(0, 6);
            if (DateTime.TryParseExact(dateOfBirth, "yyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                Console.WriteLine("Your birth date is:" + dt.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture));

            }
            else
            {
                Console.WriteLine("Invalid birth date");
            }

        }
    }
}
