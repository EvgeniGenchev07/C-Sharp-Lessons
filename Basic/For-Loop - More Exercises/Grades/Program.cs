using System;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;                    
            double sum5 = 0;
            for (int i = 1; i <= a; i++)
            {
                double b = double.Parse(Console.ReadLine());
                sum5 += b;
                if (b < 3.00)
                {
                    sum4++;
                    
                }
                else if (b <= 3.99)
                {
                    sum3++;
                    
                }
                else if (b <= 4.99)
                {
                    sum2++;
                    
                }
                else
                {
                    sum1++;
                    
                }
            }
            double average = sum5 / a;
            double top1 = sum1 / a * 100;
            double top2 = sum2 / a * 100;
            double top3 = sum3 / a * 100;
            double top4 = sum4 / a * 100;
            Console.WriteLine($"Top students: {top1:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {top2:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {top3:f2}%");
            Console.WriteLine($"Fail: {top4:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
