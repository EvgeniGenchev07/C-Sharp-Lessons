using System;

namespace Numbers_1_to_N_with_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            for (int i = 1; b >= i; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
