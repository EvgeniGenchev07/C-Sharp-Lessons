using System;

namespace Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            double sum = 0;
            if (b<=5000)
            {
                if (a == "Spring" || a == "Autumn")
                {
                    sum = b * 0.75;
                }
                else if (a =="Summer")
                {
                    sum = 0.9 * b;
                }
                else
                {
                    sum = 1.05 * b;
                }
            }
            else if (b<=10000)
            {
                if (a == "Spring" || a == "Autumn")
                {
                    sum = b * 0.95;
                }
                else if (a == "Summer")
                {
                    sum = 1.1 * b;
                }
                else
                {
                    sum = 1.25 * b;
                }
            }
            else if (b <= 20000)
            {
                if (a == "Spring" || a == "Autumn" || a == "Summer" || a =="Winter")
                {
                    sum = b * 1.45;
                }
            }
            double p = sum * 4;
            double c = p - p * 0.1;
            Console.WriteLine($"{c:f2}");
        }
    }
}
