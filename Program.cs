using System;
using System.IO.Compression;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int winNumber = random.Next(0, 10);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number in between 0 and 10");
                string s = Console.ReadLine();
                int i = int.Parse(s);

                if (i > winNumber)
                    Console.WriteLine("To high!  Guess lower...");
                else if (i < winNumber)
                    Console.WriteLine("To low!  Guess higher...");
                else if (i == winNumber)
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }
            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.Write("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}
