using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    internal class Program
    {
        
        public static void Draw1(int n,  int k)
        {
            if (n == 0) return;
            Console.WriteLine(new string('*', n));
            Draw1(n - 1, k);
            Console.WriteLine(new string('#', n));
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Draw1(n, n);
        }
    }
}
