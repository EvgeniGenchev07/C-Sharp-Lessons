using System;

namespace Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int s = a * b * c;
            int d = 0;
            while (true)
            {
                string v = Console.ReadLine();  
                if (v != "Done")
                {
                    d = int.Parse(v);
                    s-=d;
                    if (s < 0)
                    {
                        Console.WriteLine($"No more free space! You need {Math.Abs(s)} Cubic meters more.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{s} Cubic meters left.");
                    break;
                }
            }
        }
    }
}
