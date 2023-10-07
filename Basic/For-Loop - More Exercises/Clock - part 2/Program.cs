using System;

namespace Clock___part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    for (int h = 0; h < 60; h++)
                    {
                        Console.WriteLine($"{i} : {j} : {h}");
                    }
                }
            }

        }
    }

}


