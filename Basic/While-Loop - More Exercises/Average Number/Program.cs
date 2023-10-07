using System;

namespace Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double sum = 0;
            int d = 0; 
            while (true)
            {
                double b = double.Parse(Console.ReadLine());
                sum += b;
                d++;
                if (d == a)
                {
                    Console.WriteLine($"{(sum/d):f2}");
                    break;
                }
            }
        }
    }
}
