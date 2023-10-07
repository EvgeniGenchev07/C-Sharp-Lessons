using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Умножаване_на_символни_кодове
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            string str1 = str[0];
            string str2 = str[1];
            int strLengthMin = Math.Min(str1.Length,str2.Length);
            int total = 0;
            for (int i = 0; i < strLengthMin; i++)
            {
                total += str1[i] * str2[i];
            }
            if (str1.Length > str2.Length)
            {
                for (int i = strLengthMin - 1; i < str1.Length-1; i++)
                {
                    total += str1[i];
                }
                
            }
            else if (str1.Length < str2.Length)
            {
                for (int i = strLengthMin - 1; i < str2.Length-1; i++)
                {
                    total += str2[i];
                }
                
            }
            Console.WriteLine(total);
        }
    }
}
