using System;

namespace Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = a;
            for (int i = 1; i <=a; a--)
            {
                for (int d = 0; d < b; d++)
                {
                    if (a == h)
                    {
                        if (d == 0)
                        {
                            Console.Write($"L{a}{d} ");
                        }
                        else
                        {
                            Console.Write($"L{a}{d} ");
                        }
                    }
                    else if (a % 2 != 0)
                    {
                        if (d == 0)
                        {
                            Console.WriteLine("");
                            Console.Write($"A{a}{d} ");
                        }
                        else
                        {
                            Console.Write("");
                            Console.Write($"A{a}{d} ");
                        }
                    }
                    else 
                    {
                        if (d == 0)
                        {
                            Console.WriteLine("");
                            Console.Write($"O{a}{d} ");
                        }
                        else
                        {
                            Console.Write($"O{a}{d} ");
                        }
                    }
                }
            }
        }
    }
}
