using System;

namespace Trapeziod_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double S = (a + b) * h / 2;
            Console.WriteLine($"{S:f2}");   
        }
    }
}
