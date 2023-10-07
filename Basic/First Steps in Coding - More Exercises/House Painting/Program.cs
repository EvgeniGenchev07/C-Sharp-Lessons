using System;

namespace House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double iw = 2 * x * x - 1.2 * 2;
            double rw = 2 * x * y - 1.5 * 2 * 1.5;
            double o = 2 * x * y + 2 * (h * x/ 2);
            double r = o / 4.3;
            double g = (iw + rw) / 3.4;
            Console.WriteLine($"{g:f2}");
            Console.WriteLine($"{r:f2}");
        }
    }
}
