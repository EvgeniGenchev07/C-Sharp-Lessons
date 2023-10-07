using System;

namespace Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = 96 + b;
            int p = 0;
            int t = 0;
            for (int i = 1; i < a; i++)
            {
                
                
                for (int h = 1; h < a; h++)
                {
                    if (t < i)
                    {
                        t = i;
                        p++;
                    }
                    else
                    {
                        p++;
                    }
                    if (t < h)
                    {
                        t = h;
                        p++;
                    }
                    else
                    {
                        p++;
                    }
                    if (p == 2)
                    {
                        t++;
                    }
                    for (int g = 97; g <= c; g++)
                    {
                        char d = (char)g;
                        for (int k = 97; k <= c; k++)
                        {
                            char f = (char)k;
                            
                            for (int s = t; s <= a; s++)
                            {
                                Console.Write($"{i}{h}{d}{f}{s}" + " ");
                            }
                        }
                    }
                    p = 0;
                    t = 0;
                }
            }
        }
    }
}
