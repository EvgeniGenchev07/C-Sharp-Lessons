using System;

namespace Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            while (a != "Stop")
            {
                Console.WriteLine(a);
                a = Console.ReadLine();
            }
        }
    }
}
