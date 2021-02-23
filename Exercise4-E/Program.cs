using System;

namespace Exercise4_E
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                Console.Write("Enter a number: ");
                var userNum = int.Parse(Console.ReadLine());
                for (int i = userNum; i >= 0; i--)
                {
                    Console.WriteLine(i);
                }
                bool isInvalid;
                do
                {
                    Console.Write("Would you like to continue? (y/n): ");
                    response = Console.ReadLine();
                    isInvalid = response != "y" && response != "n";
                    if (isInvalid)
                    {
                        Console.WriteLine("Please enter a valid selection - 'y' or 'n'!");
                    }
                } while (isInvalid);
            } while (response == "y");
            Console.WriteLine("Goodbye!");
        }
    }
}
