using System;

namespace Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double sum = 0;
            double d = 0;
            int f = 0;
            double g = 0;
            double h = 0;
            double j = 0;
            double k = 0;
            while (true)
            {
                f++;
                string b = Console.ReadLine();
                if (b == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }
                if (sum >= a)
                {
                    Console.WriteLine($"Average CS: {(g / h):f2}");
                    Console.WriteLine($"Average CC: {(j / k):f2}");
                    break;
                }
                else
                {
                    d = double.Parse(b);
                }
                if (f % 2 != 0)
                {
                    if (d <= 100)
                    {
                        sum += d;
                        g += d;
                        h++;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                else
                {
                    if (d >= 10)
                    {
                        sum += d;
                        j += d;
                        k++;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                if (sum >= a)
                {
                    Console.WriteLine($"Average CS: {(g / h):f2}");
                    Console.WriteLine($"Average CC: {(j / k):f2}");
                    break;
                }
            }
        }
    }
}
