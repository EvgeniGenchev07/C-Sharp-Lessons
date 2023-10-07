using System;

namespace Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double l = 0;
            double sum = 0;
            double b = 0;
            while (true)
            {
                l++;
                if (l <= 12)
                {
                    b = double.Parse(Console.ReadLine());
                }
                    if (b >= 4.00)
                {
                    sum += b;
                }
                else
                {
                    Console.WriteLine($"{a} has been excluded at {l} grade");
                    break;
                    
                }
                if (l == 12)
                {
                    double sum1 = sum / 12;
                    Console.WriteLine($"{a} graduated. Average grade: {sum1:f2}");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
