using System;

namespace Exercise4_F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var userNum = int.Parse(Console.ReadLine());
            for (int i = 1; i > userNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
