using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = b * c;
            double sum = 0;
            if (a == "Premiere")
            {
                sum = d * 12;
            }
            else if (a =="Normal")
            {
                sum = d * 7.5;
            }
            else if (a =="Discount")
            {
                sum = d * 5;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
