using System;

namespace Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            if (a <= 18 & a >= 10 & b != "Sunday")
            {
                switch (b)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
