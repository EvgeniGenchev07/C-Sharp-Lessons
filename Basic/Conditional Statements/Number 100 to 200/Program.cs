﻿using System;

namespace Number_100_to_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }
           else if (num <= 101)
            {
            Console.WriteLine("Between 100 and 200");
            }
            else if (num<=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (num >= 201)
            {
                Console.WriteLine("Greater than 200");
            }
            
        }
    }
}
