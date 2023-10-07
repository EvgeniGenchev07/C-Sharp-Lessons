using System;

namespace Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;


            for (int i = 0; i < b; i++)
            {
                string c = (Console.ReadLine());
                if (c == "A")
                {
                    sum1++;
                }
                else if (c == "B")
                {
                    sum2++;
                }
                else if (c == "V")
                {
                    sum3++;
                }
                else if (c == "G")
                {
                    sum4++;
                }
            }
            double sum5 = sum1 / b * 100;
            double sum6 = sum2 / b * 100;
            double sum7 = sum3 / b * 100;
            double sum8 = sum4 / b * 100;
            double sum = b / a * 100;
            Console.WriteLine($"{sum5:f2}%");
            Console.WriteLine($"{sum6:f2}%");
            Console.WriteLine($"{sum7:f2}%");
            Console.WriteLine($"{sum8:f2}%");
            Console.WriteLine($"{sum:f2}%");




        }
    }
}
