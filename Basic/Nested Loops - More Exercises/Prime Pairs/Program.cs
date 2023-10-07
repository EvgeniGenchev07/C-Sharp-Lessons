using System;

namespace Prime_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            int c = a + f;
            int d = b + g;
            int t = 0;
            int l = 0;
            for (int i = a; i <= c; i++)
            {
                for (int h = 2; h <= i; h++)
                {
                    if (i % h == 0)
                    {
                        t++;
                    }
                }
                if (t == 1)
                {
                    for (int s = b; s <= d; s++)
                    {
                        for (int w = 2; w <= d; w++)
                        {
                            if (s % w == 0)
                            {
                                l++;
                            }
                        }
                        if (l == 1)
                        {
                            Console.WriteLine($"{i}{s}");
                            l = 0;
                        }
                        else
                        {
                            l = 0;
                        }
                    }
                    t = 0;
                }
                else
                {
                    t = 0;
                }
            }
        }
    }
}
