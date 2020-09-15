using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter day: ");
            string userInput = Console.ReadLine().ToLower();

            switch(userInput)
            {
                case "sunday":
                    Console.WriteLine("1");
                    break;
                case "monday":
                    Console.WriteLine("2");
                    break;
                case "tuesday":
                    Console.WriteLine("3");
                    break;
                case "wednesday":
                    Console.WriteLine("4");
                    break;
                case "thursday":
                    Console.WriteLine("5");
                    break;
                case "friday":
                    Console.WriteLine("6");
                    break;
                case "saturday":
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("Oops, something went wrong");
                    break;
            }
        }
    }
}
