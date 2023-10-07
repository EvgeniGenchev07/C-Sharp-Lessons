﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cmd = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> numbers = new Queue<int>();
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (cmd[0] != cmd[1])
            {
                for (int i = 0; i < cmd[0]; i++)
                {
                    numbers.Enqueue(num[i]);
                }
                for (int i = 0; i < cmd[1]; i++)
                {
                    numbers.Dequeue();
                }
                if (numbers.Contains(cmd[2])) Console.WriteLine("true");
                else { Console.WriteLine(numbers.Min()); }
            }
            else Console.WriteLine(0);
        }
    }
}
