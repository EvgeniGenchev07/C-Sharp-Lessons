using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Триъгълник_на_Паскал
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            string[,] paskal = new string[h,2*h-1];
            int p = 3;
            int n = 1;
            paskal[0, 0] = "1";
            for (int row = 1; row < h; row++)
            {
                for (int col = 0; col < p; col++)
                {
                    if (col > 0 && paskal[row, col - 1] != "   ")
                    {
                        paskal[row, col] = "   ";
                        continue;
                    }
                    if (col == 0 || col == p - 1)
                    {
                        paskal[row, col] = "1";
                        continue;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        int sum = int.Parse(paskal[row - 1, col - 2]) + int.Parse(paskal[row - 1, col]);
                        paskal[row, col] = $"{sum}";
                    }
                    n++;
                }

                if (p <= 2 * h - 2)
                {
                    p += 2;
                }
            }
            int N = h-1;
            for (int i = 0; i < h; i++)
            {
                for (int k= 0;  k< N; k++)
                {
                    Console.Write("  ");
                }
                N--;
                for (int j = 0; j < 2*h-1; j++)
                {
                    Console.Write(paskal[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
