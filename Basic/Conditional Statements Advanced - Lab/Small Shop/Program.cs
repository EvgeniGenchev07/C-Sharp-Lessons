using System;

namespace Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            double c = double.Parse(Console.ReadLine());
            double sum = 0;
            if (b == "Sofia")
            {
                switch (a)
                {
                    case "coffee":
                        sum = 0.5 * c;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "water":
                        sum = c * 0.8;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "beer":
                        sum = c * 1.2;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "sweets":
                        sum = c * 1.45;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "peanuts":
                        sum = c * 1.6;
                        Console.WriteLine($"{sum:f2}");
                        break;
                }
            }
            if (b == "Plovdiv")
            {
                switch (a)
                {
                    case "coffee":
                        sum = 0.4 * c;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "water":
                        sum = c * 0.7;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "beer":
                        sum = c * 1.15;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "sweets":
                        sum = c * 1.3;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "peanuts":
                        sum = c * 1.5;
                        Console.WriteLine($"{sum:f2}");
                        break;
                }
            }
            if (b == "Varna")
            {
                switch (a)
                {
                    case "coffee":
                        sum = 0.45 * c;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "water":
                        sum = c * 0.7;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "beer":
                        sum = c * 1.1;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "sweets":
                        sum = c * 1.35;
                        Console.WriteLine($"{sum:f2}");
                        break;
                    case "peanuts":
                        sum = c * 1.55;
                        Console.WriteLine($"{sum:f2}");
                        break;
                }
            }

        }
    }
}
