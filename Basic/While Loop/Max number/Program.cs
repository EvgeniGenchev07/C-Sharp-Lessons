using System;

namespace Max_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.MinValue;
            while (true)
            {
                string b = Console.ReadLine();
                if (b != "Stop")
                {
                    int c = int.Parse(b);
                    if (a < c)
                    {
                        a = c;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(a);
        }
    }
}
