using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Минимум_по_колони
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int colons = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows + 1, colons];
            for (int i = 0; i < rows; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            for (int i = 0; i < colons; i++)
            {
                int minNum = int.MaxValue;
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[j,i]<minNum)
                    {
                        minNum = matrix[j, i];
                    }
                }
                matrix[rows, i] = minNum;
            }
            for (int i = 0; i < rows + 1; i++)
            {
                for (int j = 0; j < colons; j++)
                {
                    Console.Write("  " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }   
    }
}
