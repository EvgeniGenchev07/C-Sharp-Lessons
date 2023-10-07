using System;

namespace Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room =Console.ReadLine();
            string a = Console.ReadLine();
            double sum = 0;
            int day = days - 1;
            if (room =="room for one person")
            {
                sum = 18.00 * day;
                if (a == "positive")
                {
                    sum = sum + sum * 0.25;  
                }
                else
                {
                    sum = sum - sum * 0.1;
                }
            }
            else if (room =="apartment")
            {
                {
                    sum = day * 25.00;
                    if (day < 10)
                    {
                        sum = sum - sum * 0.3;
                    }
                    else if (day <= 15 && day >= 10)
                    {
                        sum = sum - sum * 0.35;
                    }
                    else if (day > 15)
                    {
                        sum = sum - sum * 0.5;
                    }
                }
                if (a == "positive")
                {
                    sum = sum + sum * 0.25;
                }
                else 
                {
                    sum = sum - sum * 0.1;
                }
            }
            else if (room =="president apartment")
            {
                {
                    sum = 35.00 * day;
                    if (day < 10)
                    {
                        sum = sum - sum * 0.1;
                    }
                    else if (day <= 15 && day >= 10)
                    {
                        sum = sum - sum * 0.15;
                    }
                    else if (day > 15)
                    {
                        sum = sum - sum * 0.2;
                    }
                }
                if (a == "positive")
                {
                    sum = sum + sum * 0.25;
                }
                else
                {
                    sum = sum - sum * 0.1;
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
