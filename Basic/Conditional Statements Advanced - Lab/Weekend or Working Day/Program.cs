using System;

namespace Weekend_or_Working_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            switch (a)
            {
                case "Monday":
                    Console.WriteLine("Working day");
                    break;
                case "Tuesday":
                    Console.WriteLine("Working day");
                    break;
                case "Thursday":
                    Console.WriteLine("Working day");
                    break;
                case "Wednesday":
                    Console.WriteLine("Working day");
                    break;
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                case "Saturday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
