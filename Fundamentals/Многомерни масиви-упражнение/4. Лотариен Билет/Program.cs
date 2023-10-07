using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Лотариен_Билет
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixInfo[0] + 1, matrixInfo[1]];
            for (int i = 0; i < matrixInfo[0]; i++)
            {
                int[] row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < row.Length; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int sum1 = 0;
            int sum2 = 0;
            int sumEven = 0;
            for (int i = 0,j1=0,j2=matrixInfo[0] -1; i < matrixInfo[0]; i++,j1++,j2--)
            {
                sum1+= matrix[i,j1];
                sum2+= matrix[i,j2];
                if (matrix[i, j1]%2==0)
                {
                    sumEven += matrix[i, j1];
                }
            }
            if (sum1 == sum2)
            {
                int sumOver = 0;
                int sumUnder = 0;
                for (int i = 0, j1 = 0; i < matrixInfo[0]; i++, j1++)
                {
                    for (int j = j1+1; j < matrixInfo[1]; j++)
                    {
                        sumOver+= matrix[i,j];
                    }
                    for (int j = j1-1; j >= 0; j--)
                    {
                        sumUnder += matrix[i, j];
                    }
                }
                if (sumUnder%2!=0&&sumOver%2==0)
                {
                    Console.WriteLine("YES");
                    int sumRowEven = 0;
                    int sumColonOdd = 0;
                    for (int i = 0; i < matrixInfo[1]; i++)
                    {
                        if (matrix[0,i]%2==0) sumRowEven+=matrix[0,i]; 
                        if (matrix[matrixInfo[0] -1,i]%2==0) sumRowEven += matrix[matrixInfo[0] -1,i];
                        if (matrix[i, 0] % 2 != 0) sumColonOdd += matrix[i, 0];
                        if (matrix[i, matrixInfo[1]-1] % 2 != 0) sumColonOdd += matrix[i, matrixInfo[1]-1];
                    }
                    double sum= (sumUnder+sumEven+sumColonOdd+sumRowEven)/4;
                    Console.WriteLine($"The amount of money won is: {sum:f2}");
                }
            }
            else Console.WriteLine("NO");
        }
    }
}
