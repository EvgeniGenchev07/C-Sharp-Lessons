using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Специални_думи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List <string> doubleA = new List<string>();
            List <string> equalLetter = new List<string>();
            List<string> notEqual = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                if (word[0] == word[word.Length-1])
                {
                    equalLetter.Add(word);
                    continue;                
                }
                int count = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j]=='a')
                    {
                        count++;
                    }
                }
                if (count>=2)
                {
                    doubleA.Add(word);
                }
                else
                {
                    notEqual.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ",equalLetter));
            Console.WriteLine(string.Join(", ",doubleA));
            Console.WriteLine(string.Join(", ",notEqual));
        }
    }
}
