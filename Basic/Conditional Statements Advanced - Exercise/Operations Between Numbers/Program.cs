using System;

namespace Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            double s = 0;
            if (c == '-')
            {
                s = a - b;
                if (s % 2 == 0)
                {
                    Console.WriteLine($"{a} - {b} = {s} - even");
                }
                else if (s % 2 != 0)
                {
                    Console.WriteLine($"{a} - {b} = {s} - odd");
                }
            }
            else if (c == '*')
            {
                s = a * b;
                if (s % 2 == 0)
                {
                    Console.WriteLine($"{a} * {b} = {s} - even");
                }
                else if (s % 2 != 0)
                {
                    Console.WriteLine($"{a} * {b} = {s} - odd");
                }
            }
            else if (c == '+')
            {
                s = a + b;
                if (s % 2 == 0)
                {
                    Console.WriteLine($"{a} + {b} = {s} - even");
                }
                else if (s % 2 != 0)
                {
                    Console.WriteLine($"{a} + {b} = {s} - odd");
                }
            }
            else if (c == '/' && a != 0 && b != 0)
            {
                s = a / b;
                Console.WriteLine($"{a} / {b} = {s:f2}");

            }
            else if (c == '/' && a == 0)
            {
                Console.WriteLine($"Cannot divide {b} by zero");
            }
            else if (c == '/' && b == 0)
            {
                Console.WriteLine($"Cannot divide {a} by zero");
            }
            else if (c == '%' && a != 0 && b != 0)
            {
                s = a % b;
                Console.WriteLine($"{a} % {b} = {s}");
            }
            else if (c == '%' && a == 0)
            {
                Console.WriteLine($"Cannot divide {b} by zero");
            }
            else if (c == '%' && b == 0)
            {
                Console.WriteLine($"Cannot divide {a} by zero");


            }
        }
    }
}
