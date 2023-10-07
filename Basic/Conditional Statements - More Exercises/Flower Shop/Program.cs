using System;

namespace Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            double c = int.Parse(Console.ReadLine());
            double d = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double m = a * 3.25;
            double z = b * 4;
            double r = c * 3.50;
            double k = d * 8;
            double total = m + z + r + k - 5 * 0.01 * (m + z + r + k);
            if (total >= p)
            {
                double sum = total - p;
                Console.WriteLine($"She is left with {Math.Floor(sum)} leva.");
            }
            else
            {
                double sum = p - total;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(sum)} leva.");
            }
        }
    }
}
