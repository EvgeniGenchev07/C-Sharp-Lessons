using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Unicode_Символи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                Convert.ToChar(a[i]);
                Console.WriteLine(Convert.ToChar(a[i]));
            }
        }
    }
}
