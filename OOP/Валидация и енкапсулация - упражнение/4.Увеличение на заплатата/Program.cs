﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Увеличение_на_заплатата
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var lines = int.Parse(Console.ReadLine());
                var persons = new List<Person>();
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), double.Parse(cmdArgs[3]));
                    persons.Add(person);
                }
                var bonus = double.Parse(Console.ReadLine());
                persons.ForEach(p => p.BonusCount(bonus));
                persons.ForEach(p => Console.WriteLine(p.ToString()));
            }
            catch(ArgumentException ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
