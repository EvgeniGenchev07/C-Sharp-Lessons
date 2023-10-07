using System;

namespace Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            bool f = false;
            int k = 0;
            int y = 0;
            int sum1 = 0;
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    sum = b + c;
                    sum1 = sum;
                }
                if (i > 0)
                {
                    k = Math.Abs(sum - (b + c));
                    if (y < k)
                    {
                        y = k;
                    }
                    sum = b + c;
                    if (sum == sum1)
                    {
                        f = true;
                        break;
                    }
                }
            }
            
            if (f|| a ==1)
            {
                Console.WriteLine($"Yes, value={sum1}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={y}");
            }
        }
    }
}
