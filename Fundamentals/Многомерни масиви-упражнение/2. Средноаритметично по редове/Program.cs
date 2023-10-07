using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Средноаритметично_по_редове
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int colons = int.Parse(Console.ReadLine());
            double[,] matrix = new double[rows, colons+1];
            for (int i = 0; i < rows; i++)
            {
                double sum = 0;
                for (int j = 0; j < colons; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    sum+=matrix[i, j];
                }
                matrix[i,colons] = sum/colons;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colons+1; j++)
                {
                    Console.Write("{0,10}",matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
