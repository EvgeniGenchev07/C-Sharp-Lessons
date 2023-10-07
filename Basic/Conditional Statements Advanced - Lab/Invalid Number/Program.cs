using System;

namespace Invalid_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if(!(a >=100 & a <= 200 || a == 0))
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
