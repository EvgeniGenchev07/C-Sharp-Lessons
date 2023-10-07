using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Максимална_площадкa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] nums = new int[rows, cols];
            int[,] maxNums = new int[2,2];
            int maxSum = 0;
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    nums[i, j] = input[j];
                }
            }
            for (int col = 0; col < cols-1; col++)
            {
                for (int row = 0; row < rows-1; row++)
                {
                    sum = nums[row, col] + nums[row+1, col] + nums[row+1, col+1] + nums[row, col + 1];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        maxNums[0, 1] = nums[row, col+1];
                        maxNums[1, 1] = nums[row+1, col+1];
                        maxNums[0, 0] = nums[row, col];
                        maxNums[1, 0] = nums[row + 1, col];
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(maxNums[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
