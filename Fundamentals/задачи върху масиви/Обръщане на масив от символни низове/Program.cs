using System;
using System.Linq;

namespace Обръщане_на_масив_от_символни_низове
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(a);
            Console.WriteLine(string.Join(" ",a));
        }
    }
}
