using System;

namespace Weather_Forecast___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());
            if (C >= 26.00 & C <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if (C >= 20.1 & C <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (C >= 15.00 & C <= 20.00) 
            {
                Console.WriteLine("Mild");
            }
            else if (C >= 12.00 & C <=14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (C >= 5.00 & C <=11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
