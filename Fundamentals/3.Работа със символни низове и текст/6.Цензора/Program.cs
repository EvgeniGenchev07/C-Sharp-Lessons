using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Цензора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();
            sentence = sentence.Replace(word, new string('*', word.Length));
            Console.WriteLine(sentence);
        }
    }
}
