using System;

namespace Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i <= b; i+=2)
            {
                Console.WriteLine(Math.Pow(2 ,i));
            }
        }
    }
}
