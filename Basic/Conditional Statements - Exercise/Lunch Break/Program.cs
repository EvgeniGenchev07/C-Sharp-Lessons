using System;

namespace Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seria = Console.ReadLine();
            int tS = int.Parse(Console.ReadLine());
            int tBreak = int.Parse(Console.ReadLine());
            double eat = tBreak * 0.125;
            double lazy = tBreak * 0.25;
            double total = tBreak - lazy - eat;
            double time = total - tS;
            double time2 = tS - total;
            if (total >= tS)
            {
                Console.WriteLine($"You have enough time to watch {seria} and left with {Math.Ceiling(time)} minutes free time.");
            }
            else
                Console.WriteLine($"You don't have enough time to watch {seria}, you need {Math.Ceiling(time2)} more minutes.");

        }
    }
}
