using System;

namespace Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = 1;
            bool f = false;
            for (int i = 1; i <= a; i++)
            {
                for (int h = 0; h < i; h++)
                {
                    if (b > a)
                    {
                        f = true;
                        break;
                    }
                    Console.Write(b + " ");
                    b++;
                }
                if (f)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
