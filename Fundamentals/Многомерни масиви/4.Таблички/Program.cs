using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Таблички
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[,] output = new double[n,3];
            int[] outputNum = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int[,] table = new int[array[0], array[1]];
                for (int row = 0; row < array[0]; row++)
                {
                    int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    for (int col = 0; col < array[1]; col++)
                    {
                        table[row, col] = input[col];
                    }
                }
                int max = int.MinValue;
                int min = int.MaxValue;
                double sum = 0;
                for (int row1 = 0; row1 < array[0]; row1++)
                {
                    for (int col1 = 0; col1 < array[1]; col1++)
                    {
                        sum += table[row1, col1];
                        if (table[row1, col1] < min)
                        {
                            min= table[row1, col1];
                            output[i,0] = min;
                        }
                        if (table[row1, col1] >max)
                        {
                            max = table[row1, col1];
                            output[i, 1] = max;
                        }
                    }
                }
                double sum1 = sum / (array[0] * array[1]);
                output[i,2] = Math.Round(sum1,2);
                int count = 0;
                for (int row2 = 0; row2 < array[0]; row2++)
                {
                    for (int col2 = 0; col2 < array[1]; col2++)
                    {
                        if (table[row2,col2]>Math.Ceiling(sum1))
                        {
                            count++;
                        }
                    }
                }
                outputNum[i] = count;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(output[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(string.Join(" ",outputNum));
        }
    }
}
