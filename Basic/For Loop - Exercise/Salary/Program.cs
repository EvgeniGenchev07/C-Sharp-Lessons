using System;

namespace Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tab = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < tab; i++)
            {
                string b = Console.ReadLine();
                if (b == "Facebook")
                {
                    a -= 150;
                }
                else if (b == "Instagram")
                {
                    a -= 100;
                }
                else if (b == "Reddit")
                {
                    a -= 50;
                }
                else
                {
                    a -= 0;
                }
            }
            if (a <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
