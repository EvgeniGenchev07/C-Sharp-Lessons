using System;

namespace Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double d = 0;
            double g = 0;   
            for (int i = 0; i < a; i++)
            {
                string c = Console.ReadLine();
                if (c == "W")
                {
                    g+= 2000;
                    d++;
                }
                else if  (c == "F")
                {
                    g += 1200;
                }
                else if (c == "SF")
                {
                    g += 720;
                }
            }
            double sum = g / a;
            double f = d / a * 100;
            Console.WriteLine($"Final points: {b+g}");
            Console.WriteLine($"Average points: {Math.Floor(sum)}");
            Console.WriteLine($"{f:f2}%");
        }
    }
}
