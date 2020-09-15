using System;

namespace TestFeedback
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How did you score on your test?");
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "a":
                    Console.WriteLine("Excellent!");
                    break;
                case "b":
                    Console.WriteLine("Very good!");
                    break;
                case "c":
                    Console.WriteLine("Passed!");
                    break;
                case "d":
                    Console.WriteLine("Failed!");
                    break;
                default:
                    Console.WriteLine("Please try again.");
                    break;
            }
        }
    }
}
