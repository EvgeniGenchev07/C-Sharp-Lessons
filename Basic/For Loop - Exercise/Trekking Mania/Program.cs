using System;

namespace Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double sum = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                sum += b;
                if (b <= 5)
                {
                    sum1 += b;
                }
                else if (b <= 12)
                {
                    sum2 += b;
                }
                else if (b <= 25)
                {
                    sum3 += b;
                }
                else if (b <= 40)
                {
                    sum4 += b;
                }
                else
                {
                    sum5 += b;
                }
            }
            double c = (sum1 / sum) * 100;
            double d = (sum2 / sum) * 100;
            double e = (sum3 / sum) * 100;
            double f = (sum4 / sum) * 100;
            double g = (sum5 / sum) * 100;
            Console.WriteLine($"{c:f2}%");
            Console.WriteLine($"{d:f2}%");
            Console.WriteLine($"{e:f2}%");
            Console.WriteLine($"{f:f2}%");
            Console.WriteLine($"{g:f2}%");
        }
    }
}
