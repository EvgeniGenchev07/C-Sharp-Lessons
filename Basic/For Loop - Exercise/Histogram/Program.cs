using System;

namespace Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (b < 200)
                {
                    sum1 += 1;
                }
                else if (b >= 200 && b < 400)
                {
                    sum2++;
                }
                else if (b >= 400 && b < 600)
                {
                    sum3++;
                }
                else if (b >= 600 && b < 800)
                {
                    sum4++;
                }
                else if (b >= 800)
                {
                    sum5++;

                }
            }
            Console.WriteLine($"{(sum1 / a * 100):f2}%");
            Console.WriteLine($"{(sum2 / a * 100):f2}%");
            Console.WriteLine($"{(sum3 / a * 100):f2}%");
            Console.WriteLine($"{(sum4 / a * 100):f2}%");
            Console.WriteLine($"{(sum5 / a * 100):f2}%");

        }
    }
}
