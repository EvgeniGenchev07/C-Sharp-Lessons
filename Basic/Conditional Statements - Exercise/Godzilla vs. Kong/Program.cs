using System;

namespace Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double dress = double.Parse(Console.ReadLine());
            double decoration = money * 10 * 0.01;
            double sDress = 0;
           
            if (statists > 150)
            {
             sDress = dress * statists - dress * statists * 10 * 0.01;
            }
            else
            {
                sDress = dress * statists;
            }
            double sum = sDress + decoration;
            if (money >= sum)
            {
                double a = money - sum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {a:f2} leva left.");
            }
            else
            {
                double b = sum - money;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {b:f2} leva more.");
            }

        }
    }
}
