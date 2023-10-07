using System;

namespace Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double sum = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double sum4 = 0;
            double sum5 = 0;
            double sum6 = 0;
            for (int i = 0; i < a; i++)
            {
                double b = double.Parse(Console.ReadLine());

                if (b <= -1 || b > 50)
                {
                    sum = sum / 2;
                    sum1++;
                }
                if (b >= 40 && b <= 50)
                {
                    sum2++;
                    sum += 100;
                }

                if (b >= 30 && b <40)
                {
                    sum += 50;
                    sum3++;
                }
                if (b >= 20 && b<30)
                {
                    sum += b * 0.4;
                    sum4++;
                }
                if (b >= 10 && b<20)
                {
                    sum += b * 0.3;
                    sum5++;
                }
                if (b >= 0 && b <= 9)
                {
                    sum += b * 0.2;
                    sum6++;
                }

            }



            double sum7 = sum1 / a * 100;
            double sum8 = sum2 / a * 100;
            double sum9 = sum3 / a * 100;
            double sum10 = sum4 / a * 100;
            double sum11 = sum5 / a * 100;
            double sum12 = sum6 / a * 100;
            Console.WriteLine($"{sum:f2}");
            Console.WriteLine($"From 0 to 9: {sum12:f2}%");
            Console.WriteLine($"From 10 to 19: {sum11:f2}%");
            Console.WriteLine($"From 20 to 29: {sum10:f2}%");
            Console.WriteLine($"From 30 to 39: {sum9:f2}%");
            Console.WriteLine($"From 40 to 50: {sum8:f2}%");
            Console.WriteLine($"Invalid numbers: {sum7:f2}%");
        }
    }
}
