using System;

namespace Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            while (b<=a)
            {
                Console.WriteLine(b);
                b = 2 * b + 1;              
            }
        }
    }
}
