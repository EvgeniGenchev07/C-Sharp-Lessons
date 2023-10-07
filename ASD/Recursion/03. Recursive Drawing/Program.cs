using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Recursive_Drawing
{
    internal class Program
    {
        static void StarPrinting(int n)
        {
            if (n==0)
            {
                return;
            }
            Console.WriteLine(new string('*',n));
            StarPrinting(n-1);
        }
        static void HashTagPrinting(int k)
        {
            if (k>n)
            {
                return;
            }
            Console.WriteLine(new string('#', k));
            HashTagPrinting(k+1);
        }
        static int n;
        static void Main(string[] args)
        {
             n = int.Parse(Console.ReadLine());
            StarPrinting(n);
            HashTagPrinting(1);
        }
    }
}
