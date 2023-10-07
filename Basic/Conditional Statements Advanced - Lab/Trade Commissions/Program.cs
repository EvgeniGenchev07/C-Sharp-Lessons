using System;

namespace Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double sum = 0;
            if (a >= 0 && a <= 500)
            {
                if (city == "Sofia")
                {
                    sum = a * 0.05;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (city == "Varna")
                {
                    sum = a * 0.045;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (city == "Plovdiv")
                {
                    sum = a * 0.055;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (a <= 1000 && a > 500)
            {
                if (city == "Sofia")
                {
                    sum = a * 0.07;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (city == "Varna")
                {
                    sum = a * 0.075;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (city == "Plovdiv")
                {
                    sum = a * 0.08;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (a > 1000 && a <= 10000)
            {
                if (city == "Sofia")
                {
                    sum = a * 0.08;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (city == "Varna")
                {
                    sum = a * 0.1;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (city == "Plovdiv")
                {
                    sum = a * 0.12;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (a > 10000)
            {
                if (city == "Sofia")
                {
                    sum = a * 0.12;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (city == "Varna")
                {
                    sum = a * 0.13;
                    Console.WriteLine($"{sum:f2}");
                }
                else if (city == "Plovdiv")
                {
                    sum = a * 0.145;
                    Console.WriteLine($"{sum:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
