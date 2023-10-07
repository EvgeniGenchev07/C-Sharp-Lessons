using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Karate_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            int p = 0;
           
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == '>'&& sentence[i+1] <=57&&sentence[i+1]>=48)
                {
                     p += int.Parse(sentence[i + 1].ToString());
                    int n = p;
                        for (int j = i + 1; j <= i + p; j++)
                        {
                        if (n == 0)
                        {
                            p = 0;
                            break;
                        }
                            if (sentence[j] == '>')
                            {
                                p = p-(i+p - j);
                                break;
                            }
                            else
                            {
                                sentence = sentence.Remove(j, 1);
                                j--;
                               n--;
                            }
                        }
                        i--;
                }
            }
            Console.WriteLine(sentence);
        }
    }
}
