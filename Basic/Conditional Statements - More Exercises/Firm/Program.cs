using System;

namespace Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());   
            int workers = int.Parse(Console.ReadLine());
            double days = day - day * 0.1;
            double work = Math.Floor(days * 8 + day * 2 * workers);
            if (hours <= work)
            {
                 double a =work - hours;
                Console.WriteLine($"Yes!{a} hours left.");
            }
            else
            {
                double b =hours - work;
                Console.WriteLine($"Not enough time!{b} hours needed.");
            }
        }
    }
}
