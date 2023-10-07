using System;

namespace Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int minute = min + 15;
            int minutes = minute % 60;
            int h = minute / 60;
            
            int hours = hour + h;
            int hourS = 0;
            int minuteS = 0;
            if (minute < 60)
            {
                minuteS = min + 15;
                hours = hour;
            }
            if(minute > 60)
            {
                minuteS = minute % 60;
                hours = hour + h;
            }
            if (minute == 60)
            {
                hours = h + hours;
                minuteS = 0; 
            }
            if (hours >= 24)
            {
                hourS = hour + h - 24;
            }
            else
            {
                hourS = hour + h;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hourS}:0{minuteS}");
            }
            else
                Console.WriteLine($"{hourS}:{minuteS}");
        }
    }
}
