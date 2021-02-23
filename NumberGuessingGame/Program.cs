using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to the Guess a Number Game!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++" + "\n");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("Try to guess it, n00b." + "\n");

            int userNumber;
            string userGuess;
            do
            {
                Console.WriteLine("Enter your lousy guess: ");
                userGuess = Console.ReadLine();
                if (!int.TryParse(userGuess, out userNumber))
                {
                    Console.WriteLine("I said a NUMBER! Try again...");
                }
            } while (true);

            Console.WriteLine("You got it!");
        }

        //public static double GetDoubleWithinRange(string prompt, double min, double max)
        //{

        //}

        //public static int GetIntWithinRange(string prompt, int min, int max)
        //{

        //}
    }
}
