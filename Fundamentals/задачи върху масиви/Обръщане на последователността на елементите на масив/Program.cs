using System;
using System.Linq;

namespace Обръщане_на_последователността_на_елементите_на_масив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] t = new int[n];
            for (int i = 0; i < n; i++)
            {
                t[i] = int.Parse(Console.ReadLine());

            }
            Array.Reverse(t);
            Console.WriteLine(string.Join(" ",t));
        }
    }
}
