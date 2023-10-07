using System;

namespace Min_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            while (true)
            {
                string b = Console.ReadLine();
                if (b != "Stop")
                {
                    
                    int d = int.Parse(b);
                    if (d < a)
                    {
                           a = d;
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
