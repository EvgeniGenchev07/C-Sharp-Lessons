using System;

namespace Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int even = int.Parse(Console.ReadLine());
            
            if  (even % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
