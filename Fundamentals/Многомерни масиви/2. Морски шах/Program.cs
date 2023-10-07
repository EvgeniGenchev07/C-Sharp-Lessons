using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Морски_шах
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] chest = new char[3,3];
            char symbol = ' ';
            bool validate = false;
            for (int i = 0; i < 3; i++)
            {
                char[] array = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int j = 0; j < 3; j++)
                {
                    chest[i, j] = array[j];
                }
            }
            for (int row = 0; row < 3; row++)
            {
                if (chest[row, 0] == chest[row, 1] && chest[row, 1] == chest[row,2])
                {
                    symbol = chest[row, 0];
                    validate = true;
                    break;
                }
                else if (chest[0,row] == chest[1,row] && chest[1,row] == chest[2,row])
                {
                    symbol = chest[0,row];
                    validate = true;
                    break;
                }
                else if (row == 0)
                {
                    if (chest[row, row] == chest[row + 1, row + 1] && chest[row + 1, row + 1] == chest[row + 2, row + 2])
                    {
                        symbol = chest[row, row];
                        validate = true;
                        break;
                    }
                    if (chest[row, row+2] == chest[row + 1, row + 1] && chest[row + 1, row + 1] == chest[row + 2, row])
                    {
                        symbol = chest[row, row+2];
                        validate = true;
                        break;
                    }
                }
            }
            if (validate)
            {
                Console.WriteLine($"The winner is: {symbol}");
            }
            else
            {
                Console.WriteLine("There is no winner");
            }
        }
    }
}
