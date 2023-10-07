using System;

namespace On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ai = int.Parse(Console.ReadLine());
            int bi = int.Parse(Console.ReadLine());
            int ap = int.Parse(Console.ReadLine());
            int bp = int.Parse(Console.ReadLine());
            int sumi = ai * 60 + bi;
            int sump = ap * 60 + bp;
            int sum = 0;
            int sume = sumi - 30;
            if (sump > sumi)
            {
                sum = sump - sumi;
                if (sum < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{sum} minutes after the start");
                }
                else
                {
                    int a = sum % 60;
                    if (sum == 60)
                    {
                        sum = sum / 60;
                        Console.WriteLine("Late");
                        Console.WriteLine($"{sum}:00 hours after the start");
                    }
                    else if (sum >= 70)
                    {
                        sum = sum / 60;
                        Console.WriteLine("Late");
                        Console.WriteLine($"{sum}:{a} hours after the start");
                    }

                    else if (sum < 70 && sum > 60)
                    {
                        sum = sum / 60;
                        Console.WriteLine("Late");
                        Console.WriteLine($"{sum}:0{a} hours after the start");
                    }
                }
            }
            else if (sume > sump)
            {
                sum = sumi - sump;
                if (sum < 60)
                {

                    Console.WriteLine($"early {sum} minutes before the start");
                }
                else
                {


                    int a = sum % 60;
                    if (sum == 60)
                    {
                        sum = sum / 60;
                        Console.WriteLine($"early {sum}:00 hours before the start");
                    }
                    else if (sum >= 70)
                    {
                        sum = sum / 60;
                        Console.WriteLine($"early {sum}:{a} hours before the start");
                    }
                    else if (sum < 70 && sum > 60)
                    {
                        sum = sum / 60;
                        Console.WriteLine($"early {sum}:0{a} hours before the start");
                    }
                }
            }
            else if (sumi == sump)
            {
                Console.WriteLine("On time");
            }
            else if (sumi > sump)
            {
                sum = sumi - sump;
                Console.WriteLine("On time");
                Console.WriteLine($"{sum} minutes before the start");
            }

        }
    }
}
