using System;

namespace Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = 0;
            int sum = a * b;
            int f = a*b;
            while (true)
            {
                string c = Console.ReadLine();
                if (c != "STOP")
                {
                    d = int.Parse(c);
                    sum -= d;
                    if (sum < 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(sum)} pieces more.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"{sum} pieces are left.");
                    break;
                }
            }
        }
    }
}
