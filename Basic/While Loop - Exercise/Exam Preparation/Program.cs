using System;

namespace Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b = "";
            int c = 0;
            int d = 0;
            double sum = 0;
            string g = "";
            int f = 0;
            while (true)
            {
                if (a == d)
                {
                    Console.WriteLine($"You need a break, {d} poor grades.");
                    break;
                }
                else if (b != "Enough")
                {
                    b = Console.ReadLine();
                    if (b != "Enough")
                    {
                        c = int.Parse(Console.ReadLine());
                        f++;
                        g = b;
                        sum += c;
                    }
                    if (c <= 4.00)
                    {
                        d++;
                    }
                }
                else if (b == "Enough")
                {
                    double sum1 = sum / f;
                    Console.WriteLine($"Average score: {sum1:f2}");
                    Console.WriteLine($"Number of problems: {f}");
                    Console.WriteLine($"Last problem: {g}");
                    break;
                }
            }
        }
    }
}
