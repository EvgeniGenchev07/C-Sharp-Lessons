using System;

namespace The_song_of_the_wheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 548;
            int b = a % 10;
            int c = a%100/10;
            int d = a /100;
            Console.WriteLine($"{d} {c} {b}");
        }
    }
}
