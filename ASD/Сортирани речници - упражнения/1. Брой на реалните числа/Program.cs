using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Брой_на_реалните_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary<double, int> words = new SortedDictionary<double, int>();
            foreach (double item in input)
            {
                if (words.ContainsKey(item))
                {
                    words[item] += 1;
                }
                else
                {
                    words.Add(item, 1);
                }
            }
            foreach (var item in words)
            { 
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
