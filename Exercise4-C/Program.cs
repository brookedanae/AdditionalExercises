using System;

namespace Exercise4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
                bool isInvalid;
                do
                {

                    Console.Write("Would you like to continue? (y/n): ");
                    response = Console.ReadLine().ToLower();
                    isInvalid = response != "y" && response != "n";
                    if (isInvalid)
                    {
                        Console.WriteLine("Please enter a valid response - 'y' or 'n'! Try again...");
                    }
                } while (isInvalid);

            } while (response == "y");
            Console.WriteLine("Goodbye!");

        }
    }
}
