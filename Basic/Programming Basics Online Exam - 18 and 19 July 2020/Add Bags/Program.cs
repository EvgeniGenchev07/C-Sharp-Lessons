using System;

namespace Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if (b < 10)
            {
                double l = a * 0.01 * 20;
                if (c > 30)
                {
                    double n = l + l * 0.1;
                    double g = n * d;
                    Console.WriteLine($" The total price of bags is: {g:f2} lv.");
                }
                else if (c <= 30 & c >= 7)
                {
                    double n = l + l * 0.15;
                    double g = n * d;
                    Console.WriteLine($" The total price of bags is: {g:f2} lv.");
                }
                else if (c < 7)
                {
                    double n = l + l * 0.4;
                    double g = n * d;
                    Console.WriteLine($" The total price of bags is: {g:f2} lv.");
                }
            }
            else if (b >= 10 & b <= 20)
            {
                double p = a * 0.01 * 50;
                if (c > 30)
                {
                    double t = p + p * 0.1;
                    double f = t * d;
                    Console.WriteLine($" The total price of bags is: {f:f2} lv.");
                }
                else if (c <= 30 & c >= 7)
                {
                    double t = p + p * 0.15;
                    double f = t * d;
                    Console.WriteLine($" The total price of bags is: {f:f2} lv.");
                }
                else if (c < 7)
                {
                    double t = p + p * 0.4;
                    double f = t * d;
                    Console.WriteLine($" The total price of bags is: {f:f2} lv.");
                }
            }
            else if (b > 20)
            {
                double o = a;
                if (c > 30)
                {
                    double k = o + o * 0.1;
                    double m = k * d;
                    Console.WriteLine($" The total price of bags is: {m:f2} lv.");
                }
                else if (c <= 30 & c >= 7)
                {
                    double k = o + o * 0.15;
                    double m = k * d;
                    Console.WriteLine($" The total price of bags is: {m:f2} lv.");
                }
                else if (c < 7)
                {
                    double k = o + o * 0.4;
                    double m = k * d;
                    Console.WriteLine($" The total price of bags is: {m:f2} lv.");
                }
            }
        }
    }
}
