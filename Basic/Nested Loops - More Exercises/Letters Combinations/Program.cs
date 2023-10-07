using System;

namespace Letters_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int f = 0;
            for (int i = 'a'; i <=a; i++)
            {
                for (int g = 'a'; g <= b; g++)
                {
                    for (int h = 'a'; h <= c; h++) 
                    {
                        Console.Write($"{i}{g}{h}" + " ");
                        f++;
                    }
                }
            }
            Console.Write(f);
        }
    }
}
