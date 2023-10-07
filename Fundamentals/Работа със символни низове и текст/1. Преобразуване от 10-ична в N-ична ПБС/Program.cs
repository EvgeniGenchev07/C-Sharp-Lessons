using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Преобразуване_от_10_ична_в_N_ична_ПБС
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> n1 = new List<int>();
            int num = n[1];
            for (int i = n[1]; i > 0; i=num)
            {
                n1.Add(num % n[0]);
                num = num / n[0];
            }
            n1.Reverse();
            Console.WriteLine(string.Join("", n1));
        }
    }
}
