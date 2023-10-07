using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обръщане_на_масив_от_символни_низове
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            Array.Reverse(a);
            Console.WriteLine(string.Join(" ",a));
            Console.ReadKey();
        }
    }
}
