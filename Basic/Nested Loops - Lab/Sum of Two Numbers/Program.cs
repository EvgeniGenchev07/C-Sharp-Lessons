using System;

namespace Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = 0;

            for (int i = a; i <= b; i++)
            {
                for (int o = a; o <= b; o++)
                {
                    if (i + o == c)
                    {
                        d++;
                        Console.WriteLine($"Combination N:{d} ({i} + {o} = {c})");
                        return;
                    }
                    else
                    {
                        d++;
                    }
                }
            }
            Console.WriteLine($"{d} combinations - neither equals {c}");
        }
    }
}
