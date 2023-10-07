using System;

namespace Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = b - 1800;
            double d = 0;
            double f = 0;
            double v = 0;
            for (int i = 0; i <= c; i++)
            {
                if (i % 2 == 0)
                {
                    f += 12000;
                }
                else
                {
                    int h = i + 18;
                    v = v + 12000 + 50 * h;
                }
            }
            d = f + v;
            if (d <= a)
            {
                a -= d;
                Console.WriteLine($"Yes! He will live a carefree life and will have {a:f2} dollars left.");
            }
            else
            {
                d-= a;
                Console.WriteLine($"He will need {d:f2} dollars to survive.");
            }
        }
    }
}
