using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sum = 0;
            int l = 0;
            while (true)
            {
                string c = Console.ReadLine();
                double d = double.Parse(Console.ReadLine());
                l++;
                switch (c)
                {
                    case "save":
                        b += d;
                        sum = 0;
                        break;
                    case "spend":
                        b -= d;
                        sum++;
                        if (b < 0)
                        {
                            b = 0;
                        }
                        break;
                }
                if (sum == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(l);
                    break;
                }
                else if (b >= a)
                {
                    Console.WriteLine($"You saved the money for {l} days.");
                    break;
                }
            }
        }
    }
}
