using System;

namespace Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fTime = int.Parse(Console.ReadLine());
            int sTime = int.Parse(Console.ReadLine());
            int tTime = int.Parse(Console.ReadLine());
            int total = fTime + sTime + tTime;
            int sec = total % 60;
            int min = total / 60;
            if(sec <10)
            {
                Console.WriteLine($"{ min}:0{sec}");
            }
            else
            Console.WriteLine($"{ min}:{sec}");

        }
    }
}
