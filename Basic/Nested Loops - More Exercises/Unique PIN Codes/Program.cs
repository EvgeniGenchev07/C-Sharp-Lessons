using System;

namespace Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int f = 0;
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                for (int i = 1; i <= a; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int h = 2; h <= b; h++)
                        {
                            if (h == 4 || h == 6 || h == 8 || h == 9)
                            {
                                continue;
                            }
                            for (int g = 1; g <= c; g++)
                            {
                                if (g % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {h} {g}");
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                break;
            }
        }
    }
}
