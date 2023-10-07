    using System;

namespace Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int days = 365 - day;
            int time = day * 127 + days * 63;
            int hour = 0;
            int min = 0;
            if (time < 30000)
            {
                int time1 = 30000 - time;
                hour = time1 / 60;
                min = time1 % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hour} hours and {min} minutes less for play");
            }
            else
            {
                int time2 = time - 30000;
                hour = time2 / 60;
                min = time2 % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hour} hours and {min} minutes more for play");
            }
        }
    }
}
    

    