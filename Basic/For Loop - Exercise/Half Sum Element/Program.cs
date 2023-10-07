using System;

namespace Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int max = int.MinValue;
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                sum1 += b;
                if (max<b)
                {
                    max = b;
                }
            }
            int sum2 = sum1 - max;
            if (sum2 == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int sum3 = Math.Abs(sum2 - max);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {sum3}");
            }
        }
    }
}
