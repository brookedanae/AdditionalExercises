using System;

namespace Exercises1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.Write("Hey! What's your name? ");
            var userName = Console.ReadLine();
            Console.WriteLine($"What's up, {userName}!" + "\n");

            // Exercise 2
            Console.Write("Okay, now enter a number! ");
            var userNum = int.Parse(Console.ReadLine());
            var userNum2 = userNum + 1;
            Console.WriteLine($"Thanks, {userName}! Your number WAS {userNum}, but we added one and now it's {userNum2}!" + "\n");

            // Exercise 3
            Console.Write("This is gonna be weird, but enter another number! ");
            var userNum3 = int.Parse(Console.ReadLine());
            var userNum4 = userNum3 + 0.5;
            Console.WriteLine($"Okay so what had happened was... we took your number, {userNum3}, and added 0.5 to it. So now we have {userNum4}!");

            // Exercise 4
            Console.Write("\n" + "Now we're gonna try adding two of your numbers together! Enter one number: ");
            var userNum5 = int.Parse(Console.ReadLine());
            Console.Write("Got it. Now enter another number: ");
            var userNum6 = int.Parse(Console.ReadLine());
            var userSum = userNum5 + userNum6;
            Console.WriteLine($"Thanks! You entered: {userNum5} & {userNum6}.");
            Console.WriteLine($"Adding those together, we get {userSum}!");

            // Exercise 5
            Console.Write("I promise this is the last time I'm gonna ask! We're gonna multiply two of your numbers. Enter a number: ");
            var userNum7 = int.Parse(Console.ReadLine());
            Console.Write("Cool. Enter one last number: ");
            var userNum8 = int.Parse(Console.ReadLine());
            var userMult = userNum7 * userNum8;
            Console.WriteLine($"So you entered {userNum7} & {userNum8}...");
            Console.WriteLine($"Multipled together & we get {userMult}!" + "\n");

            Console.WriteLine("Thanks for playing!");
        }
    }
}
