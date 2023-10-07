using System;

namespace Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;
            int i = 0;
            while (true)
            {
                string a = Console.ReadLine();
                if (a == "stop")
                {
                    break;
                }
                int d = int.Parse(a);
                int f = 0;
                if (d < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                if (d > 0)
                {
                    for (i = 1; i <= 1000; i++)
                    {
                        if (d % i == 0)
                        {
                            f++;
                        }
                    }
                    i = 1;
                    if (f == 2) sum1 += d;
                    else sum2 += d; 
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sum1}");
            Console.WriteLine($"Sum of all non prime numbers is: {sum2}");
        }
    }
}
