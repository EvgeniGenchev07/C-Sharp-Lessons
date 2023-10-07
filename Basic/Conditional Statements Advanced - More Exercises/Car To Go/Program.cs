using System;

namespace Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            double sum = 0;
            if (a <= 100)
            {
                Console.WriteLine("Economy class");
                if (b == "Summer")
                {
                    sum = a * 0.35;
                    Console.WriteLine($"Cabrio - {sum:f2}");
                }
                else
                {
                    sum = a * 0.65;
                    Console.WriteLine($"Jeep - {sum:f2}");
                }
            }
            else if (a <= 500)
            {
                Console.WriteLine("Compact class");
                if (b == "Summer")
                {
                    sum = a * 0.45;
                    Console.WriteLine($"Cabrio - {sum:f2}");
                }
                else
                {
                    sum = a * 0.8;
                    Console.WriteLine($"Jeep - {sum:f2}");
                }
            }
            else
            {
                Console.WriteLine("Luxury class");
                sum = a * 0.9;
                Console.WriteLine($"Jeep - {sum:f2}");
            }
        }
    }
}
