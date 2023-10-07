using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Вход_и_изход_на_матрица
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int colons = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, colons];
            for (int i = 0; i < rows; i++)
            {
                for (int j= 0; j < colons; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colons; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
