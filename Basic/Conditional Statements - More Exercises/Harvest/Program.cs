using System;

namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());  
            int workers = int.Parse(Console.ReadLine());
            double wine = (0.4 * (x * y)) / 2.5;
            double a = 0;
            if (wine < z)
            {
                a = z - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(a)} liters wine needed.");
            }
            else
            {
                a = wine - z;
                double b = a / workers; 
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(a)} liters left -> {Math.Ceiling(b)} liters per person.");
            }
        }
    }
}



