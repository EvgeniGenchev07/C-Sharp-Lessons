using System;

namespace Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            int c = int.Parse(Console.ReadLine());
            double sum = 0;
            {
                if (b == "Spring")
                {
                    int d = 3000;
                    if (c <= 6)
                    {
                        sum = d - d * 0.1;
                    }
                    else if (c <= 6 && c % 2 == 0)
                    {
                        sum = (d - d * 0.1) - 0.05 * (d - d * 0.1);
                    }
                    else if (c >= 7 && c <= 11)
                    {
                        sum = d - d * 0.15;
                    }
                    else if (c >= 7 && c <= 11 && c % 2 == 0)
                    {
                        sum = (d - d * 0.15) - 0.05 * (d - d * 0.15);
                    }
                    else if (c >= 12)
                    {
                        sum = d - d * 0.25;
                    }
                    else if (c >= 12 && c % 2 == 0)
                    {
                        sum = (d - d * 0.25) - (d - d * 0.25) * 0.05;
                    }

                }
                if (b == "Summer")
                {
                    int d = 4200;
                    if (c <= 6)
                    {
                        sum = d - d * 0.1;
                    }
                    else if (c <= 6)
                    {
                        sum = (d - d * 0.1) - 0.05 * (d - d * 0.1);
                    }
                    else if (c >= 7 && c <= 11)
                    {
                        sum = d - d * 0.15;
                    }
                    else if (c >= 7 && c <= 11)
                    {
                        sum = (d - d * 0.15) - 0.05 * (d - d * 0.15);
                    }
                    else if (c >= 12)
                    {
                        sum = d - d * 0.25;
                    }
                    else if (c >= 12)
                    {
                        sum = (d - d * 0.25) - (d - d * 0.25) * 0.05;
                    }

                }

                if (b == "Autumn")
                {
                    int d = 4200;
                    if (c <= 6)
                    {
                        sum = d - d * 0.1;
                    }
                    else if (c <= 6)
                    {
                        sum = (d - d * 0.1) - 0.05 * (d - d * 0.1);
                    }
                    else if (c >= 7 && c <= 11)
                    {
                        sum = d - d * 0.15;
                    }
                    else if (c >= 7 && c <= 11)
                    {
                        sum = (d - d * 0.15) - 0.05 * (d - d * 0.15);
                    }
                    else if (c >= 12)
                    {
                        sum = d - d * 0.25;
                    }
                    else if (c >= 12)
                    {
                        sum = (d - d * 0.25) - (d - d * 0.25) * 0.05;
                    }

                }
                if (b == "Winter")
                {
                    int d = 2600;
                    if (c <= 6)
                    {
                        sum = d - d * 0.1;
                    }
                    else if (c <= 6)
                    {
                        sum = (d - d * 0.1) - 0.05 * (d - d * 0.1);
                    }
                    else if (c >= 7 && c <= 11)
                    {
                        sum = d - d * 0.15;
                    }
                    else if (c >= 7 && c <= 11)
                    {
                        sum = (d - d * 0.15) - 0.05 * (d - d * 0.15);
                    }
                    else if (c >= 12)
                    {
                        sum = d - d * 0.25;
                    }
                    else if (c >= 12)
                    {
                        sum = (d - d * 0.25) - (d - d * 0.25) * 0.05;
                    }

                }
                if (c % 2 == 0 && b != "Autumn")
                {
                    sum = sum - sum * 0.05;
                }
            }
            if (a >= sum)
            {
                double f = a - sum;
                Console.WriteLine($"Yes! You have {f:F2} leva left.");
            }
            else if (sum > a)
            {
                double f = sum - a;
                Console.WriteLine($"Not enough money! You need {f:F2} leva.");
            }
        }
    }
}
