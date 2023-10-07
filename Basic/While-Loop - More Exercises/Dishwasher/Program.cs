using System;

namespace Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse( Console.ReadLine() );
            int sum = 0;
            int sum1 = 750 * a;
            int d = 0;
            int g = 0;
            int h = 0;
            int f = 0;
            int t = a * 750;
            while (true)
            {
                string b =Console.ReadLine();
                if (b == "End"|| t <0)
                {
                    break;
                }                   
                d = int.Parse(b);
                g++; 
                if (g % 3 == 0)
                {
                    sum += d * 15;
                    f += d;
                    t-= d * 15;
                }
                else
                {
                    sum += d * 5;
                    h += d;
                    t -= d * 5;
                }
            }
            int k = Math.Abs(sum1 - sum);
            if (sum <= sum1)
            {
                
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{h} dishes and {f} pots were washed.");
                Console.WriteLine($"Leftover detergent {k} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {k} ml. more necessary!");
            }
        }
    }
}
