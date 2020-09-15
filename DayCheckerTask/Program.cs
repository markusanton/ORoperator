using System;

namespace DayCheckerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a day:");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "monday" || userInput == "tuesday" || userInput == "wednesday" || userInput == "thursday" || userInput == "friday")
            {
                Console.WriteLine($"{userInput} is a weekday.");
            }
            else if (userInput == "saturday" || userInput == "sunday")
            {
                Console.WriteLine($"{userInput} is the weekend.");
            }
            else
            {
                Console.WriteLine("Please enter a correct day.");
            }
        }
    }
}
