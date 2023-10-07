using System;

namespace Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int d = 0;

            for (int i = 0; i <= a; i++)
            {
                for (int b = 0; b <= a; b++)
                {
                    for (int c = 0; c <= a; c++)
                    {
                        if (i + b + c == a)
                        {
                            d++;
                        }
                    }
                }
            }
            Console.WriteLine(d);
        }
    }
}
