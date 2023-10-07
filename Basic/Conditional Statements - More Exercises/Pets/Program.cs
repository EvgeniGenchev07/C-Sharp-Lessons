using System;

namespace Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double kg = double.Parse(Console.ReadLine());
            double dogkg = double.Parse(Console.ReadLine());
            double catkg = double.Parse(Console.ReadLine());
            double turtleg = double.Parse(Console.ReadLine());
            double turtlekg = turtleg * 0.001;
            double dog = days * dogkg;
            double cat = days * catkg;
            double turtle = days * turtlekg;
            double total = dog + cat + turtle;
            if (total <= kg)
            {
                double a = kg - total;
                Console.WriteLine($"{Math.Floor(a)} kilos of food left.");
            }
            else if (total > kg)
            {
                double b = total - kg;
                Console.WriteLine($"{Math.Ceiling(b)} more kilos of food are needed.");
            }
        }
    }
}
