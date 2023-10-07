using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Палиндром
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = null;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b += a[i];
            }
            if (a.CompareTo(b) == 0) Console.WriteLine(true);
            else Console.WriteLine(false);
        }
    }
}
