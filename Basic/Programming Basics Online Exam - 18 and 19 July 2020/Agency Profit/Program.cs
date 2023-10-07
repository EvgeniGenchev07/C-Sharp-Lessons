using System;

namespace Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double f = d - d * 0.01 * 70;
            double g = (f + e) * c;
            double h = (d + e) * b;
            double i = (h + g) * 0.2;
            Console.WriteLine($"The profit of your agency from {a} tickets is {i:f2} lv.");
        }
    }
}
