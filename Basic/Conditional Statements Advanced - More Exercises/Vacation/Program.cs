using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a =double.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            double sum = 0;
            //"Summer" и "Winter". Локациите са – "Alaska" и "Morocco". Възможните места за настаняване – "Hotel", "Hut" или "Camp".
            if (a <=1000)
            {
                if (b == "Summer")
                {
                    sum = a * 0.65;
                    Console.WriteLine($"Alaska - Camp - {sum:f2}");
                }
                else
                {
                    sum = a * 0.45;
                    Console.WriteLine($"Morocco - Camp - {sum:f2}");
                }
            }
            else if (a <=3000)
            {
                if (b == "Summer")
                {
                    sum = a * 0.8;
                    Console.WriteLine($"Alaska - Hut - {sum:f2}");
                }
                else
                {
                    sum = a * 0.6;
                    Console.WriteLine($"Morocco - Hut - {sum:f2}");
                }
            }
            else if (a > 3000)
            {
                if (b == "Summer")
                {
                    sum = a * 0.9;
                    Console.WriteLine($"Alaska - Hotel - {sum:f2}");
                }
                else
                {
                    sum = a * 0.9;
                    Console.WriteLine($"Morocco - Hotel - {sum:f2}");
                }
            }
        }
    }
}
