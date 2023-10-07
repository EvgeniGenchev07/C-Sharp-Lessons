using System;

namespace Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            

            int sum1 = 0;
            int sum2 = 0;
            for (int i = a; i <= b; i++)
            {
                string c = Convert.ToString(i);
                for (int h = 0; h < c.Length; h++)
                {
                    int d = int.Parse(c[h].ToString());
                    if (d == 0) continue;
                    if (h % 2 == 0) sum1 += d;
                    else sum2 += d;
                }
                if (sum1 == sum2)
                {
                    Console.Write(i + " ");
                    sum1 = 0;
                    sum2 = 0;
                }
                else
                {
                    sum1 = 0;
                    sum2 = 0;
                }
            }
        }
    }
}