using System;

namespace Exercise4_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            bool isInvalid;
            do
            {
                Console.WriteLine("Hello, World!");
                do
                {
                    Console.WriteLine("Would you like to continue? (y/n): ");
                    response = Console.ReadLine().ToLower();
                    isInvalid = response != "y" && response != "n";
                    if (isInvalid)
                    {
                        Console.WriteLine("Please enter a valid selection!");
                    }
                } while (isInvalid);

            } while (response == "y");
            Console.WriteLine("Goodbye!");

        }
    }
}
