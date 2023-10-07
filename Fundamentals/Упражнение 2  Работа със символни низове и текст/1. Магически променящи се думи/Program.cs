using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Магически_променящи_се_думи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string word1 = words[0];
            string word2 = words[1];
            int len = Math.Min(word1.Length, word2.Length);
            int firstLen = word1.ToCharArray().Distinct().Count();
            int secondLen = word2.ToCharArray().Distinct().Count();
            if (firstLen != secondLen)
            {

                Console.WriteLine("False");
            }

            else
            {
                for (int i = 1; i < len; i++)
                {

                    bool isCheck = word1[i] == word2[i - 1];
                    bool isCheck1 = word2[i] == word2[i - 1];

                    if (isCheck != isCheck1) Console.WriteLine("False");
                }
                    Console.WriteLine("True");
                }
            }
    }
}
