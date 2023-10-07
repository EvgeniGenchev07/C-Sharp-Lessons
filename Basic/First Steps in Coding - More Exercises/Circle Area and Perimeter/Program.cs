using System;

namespace Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double S = r * r * Math.PI;
            double P = 2 * Math.PI * r;
            Console.WriteLine($"{S:f2}");
            Console.WriteLine($"{P:f2}");
        }
    }
}
