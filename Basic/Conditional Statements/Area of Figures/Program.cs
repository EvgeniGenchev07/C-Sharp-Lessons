using System;

namespace Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            if (name == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double S = a * a;
                Console.WriteLine($"{S:f3}");
            }
            else if (name == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = a * b;
                Console.WriteLine($"{S:f3}");
            }
            else if (name == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double S = a * a * Math.PI;
                Console.WriteLine($"{S:f3}");
            }
            else if (name == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = a * b * 0.5;
                Console.WriteLine($"{S:f3}");
            }
        }
    }
}
