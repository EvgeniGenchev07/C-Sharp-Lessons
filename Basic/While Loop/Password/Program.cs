using System;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            while (true)
            {
                if (c != b)
                {
                c = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Welcome {a}!");
                    break;
                }
            }
        }
    }
}
