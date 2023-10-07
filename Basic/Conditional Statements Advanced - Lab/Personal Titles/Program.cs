using System;

namespace Personal_Titles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            if (b == "m")
            {
                if (a < 16)
                {
                    Console.WriteLine("Master");
                }
                if (a >= 16)
                {
                    Console.WriteLine("Mr.");
                }
            }
            if (b == "f")
            {
                if (a < 16)
                {
                    Console.WriteLine("Miss");
                }
                if (a >= 16)
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
