using System;

namespace World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sec = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double sec1 = double.Parse(Console.ReadLine());
            double swim = sec1 * m;
            double sec2 = Math.Floor((m / 15)) * 12.5;
            double tSec = swim + sec2;
            double Nsec = tSec - sec;
            if (tSec < sec)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {tSec:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Nsec:f2} seconds slower.");
            }
        }
    }
}
