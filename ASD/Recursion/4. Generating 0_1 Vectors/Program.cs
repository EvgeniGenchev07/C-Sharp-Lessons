using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Generating_0_1_Vectors
{
    internal class Program
    {
        static void GenerateCombinations(int index)
        {
            if (index == n)
            {
                Print();
                return;
            }
            for (int i = 0; i <=1 ; i++)
            {
                combination[index] = i;
                GenerateCombinations(index+1);
            }
        }
        static void Print()
        {
            Console.WriteLine(string.Join("",combination));
        }
        static int n;
        static int[] combination;
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            combination = new int[n];
            GenerateCombinations(0);
        }
    }
}
