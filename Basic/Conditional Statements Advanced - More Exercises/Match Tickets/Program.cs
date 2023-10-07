using System;

namespace Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            double c = int.Parse(Console.ReadLine());

            if (b == "Normal")
            {
                double sum = 0;
                {
                    double s = 249.99;
                    if (c <= 4)
                    {
                        sum = a * 0.01 * 75 + c * s;
                    }
                    else if (c <= 9)
                    {
                        sum = a * 0.01 * 60 + s * c;
                    }
                    else if (c <= 24)
                    {
                        sum = a * 0.01 * 50 + c * s;
                    }
                    else if (c <= 49)
                    {
                        sum = a * 0.01 * 40 + s * c;
                    }
                    else
                    {
                        sum = a * 0.01 * 25 + c * s;
                    }
                }
                if (sum <= a)
                {
                    double v = a - sum;
                    Console.WriteLine($"Yes! You have {v:f2} leva left.");
                }
                else
                {
                    double o = sum - a;
                    Console.WriteLine($"Not enough money! You need {o:f2} leva.");
                }
            }
            else
            {
                double sum = 0;
                {
                    double p = 499.99;
                    if (c <= 4)
                    {
                        sum = a * 0.01 * 75 + c * p;
                    }
                    else if (c <= 9)
                    {
                        sum = a * 0.01 * 60 + p * c;
                    }
                    else if (c <= 24)
                    {
                        sum = a * 0.01 * 50 + c * p;
                    }
                    else if (c <= 49)
                    {
                        sum = a * 0.01 * 40 + p * c;
                    }
                    else
                    {
                        sum = a * 0.01 * 25 + c * p;
                    }
                }
                if (sum <= a)
                {
                    double v = a - sum;
                    Console.WriteLine($"Yes! You have {v:f2} leva left.");
                }
                else
                {
                    double o = sum - a;
                    Console.WriteLine($"Not enough money! You need {o:f2} leva.");
                }
            }
        }
    }
}
