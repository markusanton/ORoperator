using System;
using System.Globalization;

namespace ORoperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month were you born?");
            string userMonth = Console.ReadLine().ToLower();

            if (userMonth == "december" || userMonth == "january" || userMonth == "february")
            {
                Console.WriteLine("You were born in winter.");
            }
            else if (userMonth == "march" || userMonth == "april" || userMonth == "may")
            {
                Console.WriteLine("You were born in spring.");
            }
            else if (userMonth == "june" || userMonth == "july" || userMonth == "august")
            {
                Console.WriteLine("You were born in Summer.");
            }
            else if (userMonth == "september" || userMonth == "october" || userMonth == "november")
            {
                Console.WriteLine("You were born in fall.");
            }
            else
            {
                Console.WriteLine("Please enter a correct month.");
            }

        }
    }
}
