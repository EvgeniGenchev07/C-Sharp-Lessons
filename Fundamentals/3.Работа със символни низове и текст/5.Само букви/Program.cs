using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Само_букви
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <char> sentence = Console.ReadLine().ToList();
            bool break1 = true;
            for (int i = 0; i < sentence.Count; i++)
            {
                if (sentence[i] <= 57 && sentence[i]>=48)
                {
                    int count = 1;
                    for (int j = i+1; j <= sentence.Count-1; j++)
                    {
                        
                        if (sentence[j] <= 57 && sentence[j] >= 48) count++;
                        else break;
                        if (sentence.Count - 1 == j && sentence[j] <= 57 && sentence[j] >= 48)
                        {
                            break1 = false;
                            break;
                        }
                    }
                    if (break1)
                    {
                        sentence.RemoveRange(i, count);
                        sentence.Insert(i, sentence[i]);
                    }
                    else break;
                }
            }
            Console.WriteLine(string.Join("",sentence));
        }
    }
}
