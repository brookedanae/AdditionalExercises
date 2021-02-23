using System;

namespace Exercise4_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                Console.Write("Enter some text: ");
                var userInput = Console.ReadLine();
                Console.WriteLine(userInput + "\n");
                bool isInvalid;
                do
                {
                    Console.Write("Cool. Would you like to add some more? (y/n): ");
                    response = Console.ReadLine().ToLower();
                    isInvalid = response != "y" && response != "n";
                    if (isInvalid)
                    {
                        Console.WriteLine("Please enter a valid response! 'y' or 'n'");
                    }
                } while (isInvalid);

            } while (response == "y");
            Console.WriteLine("Goodbye!");
        }
    }
}
