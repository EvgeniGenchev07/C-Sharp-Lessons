using System;

namespace Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
          
            double sum1 = 0;
            double sum2 = 20 * a;
            double sum3 = 15 * a;
            double sum4 = 0;
            
            for (int i = 1; i <= a; i++)
            {
                double b = double.Parse(Console.ReadLine());
                sum1 += b;
                double sum5 = b;
                sum4 += (((sum5 + 20 + 15) * 0.2) + sum5 + 20 + 15);
            }
            
            double sum = (sum4 + sum3 + sum1 + sum2) / a;
            Console.WriteLine($"Electricity: {sum1:f2} lv");
            Console.WriteLine($"Water: {sum2:f2} lv");
            Console.WriteLine($"Internet: {sum3:f2} lv");
            Console.WriteLine($"Other: {sum4:f2} lv");
            Console.WriteLine($"Average: {sum:f2} lv");
        }
    }
}
