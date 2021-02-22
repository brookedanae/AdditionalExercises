using System;

namespace Exercise2_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello and welcome to The Raptor!" + "\n");
            string response;
            do
            {
                Console.WriteLine("Please enter your height in inches: ");
                var userInput = double.Parse(Console.ReadLine());

                if (userInput < 54)
                {
                    var heightDiff = 54 - userInput;
                    Console.WriteLine($"Sorry, you cannot ride the Raptor. You need {Math.Round(heightDiff)} more inches.");
                }
                else
                {
                    Console.WriteLine("You can ride the Raptor! Welcome aboard :)");
                }

                Console.WriteLine("Would you like to continue? (y/n): ");
                response = Console.ReadLine().ToLower();
            } while (response == "y") ;

            Console.WriteLine("Thanks for visiting The Raptor! See ya next time!");


        }
    }
}
