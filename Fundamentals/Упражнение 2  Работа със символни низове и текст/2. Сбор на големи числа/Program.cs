using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Сбор_на_големи_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            if (first.Length > second.Length) second = second.PadLeft(first.Length, '0');
            else first = first.PadLeft(second.Length, '0');
            byte sum = 0;
            byte reminder = 0;
            byte addToMind = 0;
            StringBuilder result = new StringBuilder();
            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = (byte)(byte.Parse(first[i].ToString()) + byte.Parse(second[i].ToString()) + addToMind);
                reminder = (byte)(sum % 10);
                addToMind = (byte)(sum / 10);
                result.Append(reminder);
                if (addToMind >= 1 && i == 0)
                {
                    result.Append(addToMind);

                }

            }
            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();
        }
    }
}
