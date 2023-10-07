using System;

namespace Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fish1 = double.Parse(Console.ReadLine());
            double fish2 = double.Parse(Console.ReadLine());
            double fish3 = double.Parse(Console.ReadLine());
            double fish4 = double.Parse(Console.ReadLine());
            double fish5 = double.Parse(Console.ReadLine());
            double fishP = (fish1 + fish1 * 0.60) * fish3;
            double fishC = (fish2 * 0.8 + fish2) * fish4;
            double fishM = fish5 * 7.50;
            double sum = fishP + fishC + fishM;
            Console.WriteLine($"{sum:f2}");

        }
    }
}
