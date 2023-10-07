using System;

namespace Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            if (n < 20 & time == "day")
            {
               double sum = 0.70 + n * 0.79;
                Console.WriteLine($"{sum:f2}");
            }
            else if (n < 20 & time == "night")
            {
                double sum = 0.70 + n * 0.90;
                Console.WriteLine($"{sum:f2}");
            }
            else if (n >= 20 & n < 100 & time == "night")
            {
                double sum = n * 0.09;
                Console.WriteLine($"{sum:f2}");
            }
            else if (n >= 20 & n < 100 & time == "day")
            {
                double sum = n * 0.09;
                Console.WriteLine($"{sum:f2}");
            }
            else if (n >= 100 & time == "night")
            {
               double sum = n * 0.06;
                Console.WriteLine($"{sum:f2}");
            }
            else if (n >= 100 & time == "day")
            {
                double sum = n * 0.06;
                Console.WriteLine($"{sum:f2}");
            }
        }   
    }
}
