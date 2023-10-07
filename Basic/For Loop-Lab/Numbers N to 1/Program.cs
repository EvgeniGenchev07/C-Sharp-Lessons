using System;

namespace Numbers_N_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            for (int i = b; 1 <= i; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
