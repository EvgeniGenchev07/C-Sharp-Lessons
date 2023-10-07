using System;

namespace Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum1 += b;
                }
                if (i % 2 != 0)
                {
                    sum2 += b;
                }
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                double d = Math.Abs(sum2 - sum1);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {d}");
            }
        }
    }
}
