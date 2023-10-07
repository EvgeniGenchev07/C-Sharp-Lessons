using System;

namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double c = 0;
            double d = 0;
            //May, June, July, August, September или October
            if (a == "May"|| a == "October")
            {
                c = b * 50;
                d = b * 65;
                if (b >7 && b <=14)
                {
                    c = c - c * 0.05;
                }
                else if (b > 14)
                {
                    c = c - c * 0.3;
                    d = d - d * 0.1;
                }
            }
            else if (a == "June" || a == "September")
            {
                c = b * 75.20;
                d = b * 68.70;
                if (b > 14)
                {
                    c = c - c * 0.2;
                    d = d - d * 0.1;
                }
            }
            else if (a == "July" || a == "August")
            {
                c = b * 76;
                d = b * 77;
                if (b > 14)
                {
                    d = d - d * 0.1;
                }
            }
            Console.WriteLine($"Apartment: {d:f2} lv.");
            Console.WriteLine($"Studio: {c:f2} lv.");
        }
    }
}
