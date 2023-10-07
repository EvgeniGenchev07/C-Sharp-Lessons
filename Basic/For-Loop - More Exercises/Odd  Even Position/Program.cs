using System;

namespace Odd__Even_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double m = double.MaxValue;
            double n = double.MaxValue;
            double r = double.MinValue;
            double o = double.MinValue;
            double sume = 0;
            double sumo = 0;
            for (int i = 1; i <= a; i++)
            {
                double s = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    sumo += s;
                    if (s < m)
                    {
                        m = s;
                    }
                    if (s > r)
                    {
                        r = s;
                    }
                }
                

                if (i % 2 == 0)
                {
                    sume += s;
                    if (s < n)
                    {
                        n = s;
                    }
                    if (s > o)
                    {
                        o = s;
                    }
                }
            }
            if (a < 1)
            {
                Console.WriteLine("OddSum=0.00,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (a == 1)
            {
                Console.WriteLine($"OddSum={sumo:f2},");
                Console.WriteLine($"OddMin={m:f2},");
                Console.WriteLine($"OddMax={r:f2},");
                Console.WriteLine("EvenSum=0.00,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={sumo:f2},");
                Console.WriteLine($"OddMin={m:f2},");
                Console.WriteLine($"OddMax={r:f2},");
                Console.WriteLine($"EvenSum={sume:f2},");
                Console.WriteLine($"EvenMin={n:f2},");
                Console.WriteLine($"EvenMax={o:f2}");
            }
        }
    }
}
