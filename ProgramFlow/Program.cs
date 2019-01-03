using System;

namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int ourNum = 10;

            Console.WriteLine("Please guess the number");
            String answer = Console.ReadLine();
            int guessNum = 0;
            Int32.TryParse(answer, out guessNum);

            if (guessNum == ourNum)
            {
                Console.WriteLine("Correct! Good job!");
            }
            else
            {
                Console.WriteLine("Sorry, you didn't guess the right number!");
            }
            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
        }
    }
}
