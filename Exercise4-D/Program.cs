using System;

namespace Exercise4_D
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                for (int i = 9; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
                bool isInvalid;
                do
                {
                    Console.Write("Would you like to continue? (y/n): ");
                    response = Console.ReadLine().ToLower();
                    isInvalid = response != "n" && response != "y";
                    if (isInvalid)
                    {
                        Console.WriteLine("Please enter a valid response - 'y' or 'n'!");
                    }
                } while (isInvalid);
            } while (response == "y");
            Console.WriteLine("Goodbye!");
        }
    }
}
