using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Обработка_на_числа_с_представки_и_наставки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            double total = 0;
            string sNum = null;
            for (byte i = 0; i < input.Count; i++)
            {
                for (int j = 1; j < input[i].Length-1; j++)
                {
                    sNum += input[i][j].ToString();
                }
                double num = double.Parse(sNum);
                sNum = null;
                if (input[i][0] >= 65 && input[i][0] <= 90) num /= (input[i][0] - 64);
                else num *= (input[i][0] - 96);
                if (input[i][input[i].Length - 1] >= 65 && input[i][input[i].Length-1] <= 90) num -= (input[i][input[i].Length - 1] - 64);
                else num += (input[i][input[i].Length - 1] - 96);
                total += num;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
