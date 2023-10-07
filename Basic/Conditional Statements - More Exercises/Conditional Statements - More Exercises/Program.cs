using System;

namespace Conditional_Statements___More_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            double lp1 = H * P1;
            double lp2 = H * P2;
            double lp = lp1 + lp2;
            double t1 = (lp1 / lp) * 100;
            double t2 = (lp2 / lp) * 100;
            double V2 = (lp / V) * 100;
            if (V2 <= 100)
            {
                Console.WriteLine($"The pool is {V2}% full. Pipe 1: {t1}%. Pipe 2: {t2}%.");
            }
            else
            {
                double av = lp - V;
                Console.WriteLine($"For {H} hours the pool overflows with {av} liters.");
            }


        }
    }
}
