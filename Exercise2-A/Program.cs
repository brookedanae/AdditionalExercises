using System;

namespace Exercise2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Hello! Please choose between English, Spanish, or Dutch! Enter a language:");
                var userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "english":
                        Console.WriteLine("Hello, World!");
                        break;
                    case "spanish":
                        Console.WriteLine("Hola Mundo!");
                        break;
                    case "dutch":
                        Console.WriteLine("Hallo wereld!");
                        break;
                    default:
                        Console.WriteLine("Not a valid selection!");
                        break;
                }

                Console.WriteLine("Would you like to continue? (y/n): ");
                answer = Console.ReadLine().ToLower();
            } while (answer == "y");

            Console.WriteLine("Thank you! Goodbye!");
        }
    }
}
