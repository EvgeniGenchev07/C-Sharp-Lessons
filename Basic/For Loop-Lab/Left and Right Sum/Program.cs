using System;

namespace Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            int d = 0;
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                sum += b;
            }
            for (int i = 0; i < a; i++)
            {
                int c = int.Parse(Console.ReadLine());
                sum1 += c;
            }
            if (sum1 > sum || sum > sum1)
            {
                d = Math.Abs(sum - sum1);
                Console.WriteLine($"No, diff = {d}");
            }
            else
            {
                d = sum;
                Console.WriteLine($"Yes, sum = {sum}");
            }

        }
    }
}
