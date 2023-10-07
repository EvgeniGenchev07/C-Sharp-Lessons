using System;

namespace Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            for (int i = 1; i <= y; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 =sum1 +(i* 5 -1);
                }
                else
                {
                    sum++;
                }
            }


            int sum2 = sum * b;
            int sum3 = sum2 + sum1;
            if (sum3 >= a)
            {
                double sum4 = sum3 - a;
                Console.WriteLine($"Yes! {sum4:f2}");

            }
            else
            {
                double sum5 = a - sum3;
                Console.WriteLine($"No! {sum5:f2}");
            }
        }
    }
}
