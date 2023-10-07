using System;

namespace Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            if (a == "Diesel" & b < 25)
            {
                Console.WriteLine($"Fill your tank with diesel!");
            }
            else if (a == "Diesel" & b >= 25)
            {
                Console.WriteLine($"You have enough diesel.");
            }
            else if (a == "Gasoline" & b >= 25)
            {
                Console.WriteLine($"You have enough gasoline.");
            }
            else if (a == "Gasoline" & b < 25)
            {
                Console.WriteLine($"Fill your tank with gasoline!");
            }
            else if (a == "Gas" & b < 25)
            {
                Console.WriteLine($"Fill your tank with gas!");
            }
            else if (a == "Gas" & b >= 25)
            {
                Console.WriteLine($"You have enough gas.");
            }
            else if (a != "Gas")
            {
                Console.WriteLine($"Invalid fuel!");
            }
            else if (a !="Gasline")
            {
                Console.WriteLine($"Invalid fuel!");
            }
            else if (a != "Diesel")
            {
                Console.WriteLine($"Invalid fuel!");
            }
        }
    }
}
