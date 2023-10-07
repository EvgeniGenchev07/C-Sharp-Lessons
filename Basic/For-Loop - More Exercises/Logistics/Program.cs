using System;

namespace Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4= 0;
            double sum5 = 0;
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                sum5 += b;
                if (b <= 3)
                {
                    sum2 += b;
                    
                }
                else if (b <= 11)
                {
                    sum3 += b;
                    
                }
                else
                {
                    sum4 += b;
                    
                }
            }
            sum1 = 200 * sum2 + 175 * sum3 + 120 * sum4;
            double sum6 = sum1 / sum5;
            double sum7 = sum2 / sum5 * 100;
            double sum8 = sum3 / sum5 * 100;
            double sum9 = sum4 / sum5 * 100;
            Console.WriteLine($"{sum6:f2}");
            Console.WriteLine($"{sum7:f2}%");
            Console.WriteLine($"{sum8:f2}%");
            Console.WriteLine($"{sum9:f2}%");
        }
    }
}
