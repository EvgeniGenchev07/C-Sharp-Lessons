using System;

namespace Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            char d = char.Parse(Console.ReadLine());
            double sum = 0;
            int v = x + l + r;
            if (s == "Spring" && d == 'N')
            {
                double sum1 = x * 2 + r * 4.10 + l * 2.50;
                if (l > 7 && v > 20)
                    sum = (sum1 - sum1 * 0.05) - (sum1 - sum1 * 0.05) * 0.2 + 2;
                else if (l > 7)
                {
                    sum = (sum1 - sum1 * 0.05) + 2;
                }
                else if (v > 20)
                {
                    sum = (sum1 - sum1 * 0.2) + 2;
                }
                else
                {
                    sum = sum1 + 2;
                }
            }
            else if (s == "Spring" && d == 'Y')
            {
                double sum2 = x * 2 + r * 4.10 + l * 2.50;
                double sum1 = sum2 + sum2 * 0.15;
                if (l > 7 && v > 20)
                    sum = (sum1 - sum1 * 0.05) - (sum1 - sum1 * 0.05) * 0.2 + 2;
                else if (l > 7)
                {
                    sum = (sum1 - sum1 * 0.05) + 2;
                }
                else if (v > 20)
                {
                    sum = (sum1 - sum1 * 0.2) + 2;
                }
                else
                {
                    sum = sum1 + 2;
                }
            }
            else if (s == "Summer" && d == 'N')
            {
                double sum1 = x * 2 + r * 4.10 + l * 2.50;
                if (v > 20)
                {
                    sum = (sum1 - sum1 * 0.2) + 2;
                }
                else
                {
                    sum = sum1 + 2;
                }
            }
            else if (s == "Summer" && d == 'Y')
            {
                double sum2 = x * 2 + r * 4.10 + l * 2.50;
                double sum1 = sum2 + sum2 * 0.15;
                if (v > 20)
                {
                    sum = (sum1 - sum1 * 0.2) + 2;
                }
                else
                {
                    sum = sum1 + 2;
                }
            }
            else if (s == "Autumn" && d == 'N')
            {
                double sum1 = x * 3.75 + r * 4.50 + l * 4.15;
                if (v > 20)
                {
                    sum = (sum1 - sum1 * 0.2) + 2;
                }
                else
                {
                    sum = sum1 + 2;
                }
            }
            else if (s == "Autumn" && d == 'Y')
            {
                double sum2 = x * 3.75 + r * 4.50 + l * 4.15;
                double sum1 = sum2 + sum2 * 0.15;
                if (v > 20)
                {
                    sum = (sum1 - sum1 * 0.2) + 2;
                }
                else
                {
                    sum = sum1 + 2;
                }
            }
            else if (s == "Winter" && d == 'N')
            {
                double sum1 = x * 3.75 + r * 4.50 + l * 4.15;
                double sum3 = sum1 - sum1 * 0.1;
                if (r >= 10 && v > 20)
                    sum = sum3 - sum3 * 0.2 + 2;
                else if (r >= 10)
                {
                    sum = (sum1 - sum1 * 0.1) + 2;
                }
                else if (v > 20)
                {
                    sum = (sum1 - sum1 * 0.2) + 2;
                }
                else
                {
                    sum = sum1 + 2;
                }
            }
            else if (s == "Winter" && d == 'Y')
            {
                double sum2 = x * 3.75 + r * 4.50 + l * 4.15;
                double sum1 = sum2 + sum2 * 0.15;
                if (r>=10&&v>20)
                    sum = (sum1 - sum1 * 0.1) - (sum1 - sum1 * 0.1) * 0.2 + 2;
                else if (r >= 10)
                {
                    sum = (sum1 - sum1 * 0.1) + 2;
                }
                else if (v > 20)
                {
                    sum = (sum1 - sum1 * 0.2) + 2;
                }
                else
                {
                    sum = sum1 + 2;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
