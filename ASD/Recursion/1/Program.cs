﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static int Factoriel(int n)
        {
            if (n==0)
            {
                return 1;
            }
            return n * Factoriel(n-1);
        }
       
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());


            Console.WriteLine(Factoriel(n)); 
        }
    }
}
