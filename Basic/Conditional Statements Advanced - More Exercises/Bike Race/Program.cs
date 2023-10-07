using System;

namespace Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();
            double sum = 0;
            int d = j + s;
            //"trail", "cross-country", "downhill" или "road"
            if (a == "trail")
            {
                sum = j * 5.50 + s * 7;
            }
            else if (a == "cross-country")
            {
                sum = j * 8 + s * 9.50;
                if (d>=50)
                {
                    sum = sum - sum * 0.25;
                }
            }
            else if (a == "downhill")
            {
                sum = j * 12.25 + s * 13.75;
            }
            else if (a == "road")
            {
                sum = j * 20 + s * 21.50;
            }
            double c = sum - sum * 0.05;
            Console.WriteLine($"{c:f2}");
        }
    }
}
