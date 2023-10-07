using System;

namespace Journey
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
                if (b == "summer")
                {
                    sum = a * 0.3;
                    string s = "Camp";
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"{s} - {sum:f2}");
                    
                }
                else
                {
                    sum = a * 0.7;
                    string s = "Hotel";
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"{s} - {sum:f2}");
                }

            }
            else if (a <= 1000)
            {
                if (b == "summer")
                {
                    sum = a * 0.4;
                    string s = "Camp";
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"{s} - {sum:f2}");

                }
                else
                {
                    sum = a * 0.8;
                    string s = "Hotel";
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"{s} - {sum:f2}");
                }
            }
            else if (a > 1000)
            {
                if (b == "summer")
                {
                    sum = a * 0.9;
                    string s = "Hotel";
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"{s} - {sum:f2}");

                }
                else
                {
                    sum = a * 0.9;
                    string s = "Hotel";
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine($"{s} - {sum:f2}");
                }
            }


        }
    }
}
