using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Обръщане_на_низ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = null;
            for (int i = a.Length-1; i>=0; i--)
            {
                b += a[i];
            }
            Console.WriteLine(b);
        }
    }
}
