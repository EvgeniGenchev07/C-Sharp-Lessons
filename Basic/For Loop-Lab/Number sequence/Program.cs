using System;

namespace Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int num1 = int.MinValue;
            int num2 = int.MaxValue;
            {
                for (int i = 0; i < a; i++)
                {
                    int b = int.Parse(Console.ReadLine());

                    if (b > num1)
                    {
                        num1 = b;
                    }

                    if (b < num2)
                    {
                        num2 = b;
                    }

                }
                Console.WriteLine($"Max number: {num1}");
                Console.WriteLine($"Min number: {num2}");
            }


        }
    }
}
