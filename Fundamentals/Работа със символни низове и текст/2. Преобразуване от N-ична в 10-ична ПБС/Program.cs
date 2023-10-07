using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Преобразуване_от_N_ична_в_10_ична_ПБС
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int baseNum = int.Parse(input[0]);
            double total = 0;
            string sNum = input[1];
            for (int i = 0; i < input[1].Length; i++)
            {
                int n = int.Parse(sNum[i].ToString());
                total += Math.Pow(baseNum, sNum.Length - 1 - i) * n;
            }
            Console.WriteLine(total);
        }
    }
}
