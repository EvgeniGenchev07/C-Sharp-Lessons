using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Нечетни_срещания
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');
            Dictionary<string,int> words = new Dictionary<string,int>();
            List<string> output = new List<string>();
            foreach (string item in input) 
            {
                if (words.ContainsKey(item))
                {
                    words[item] +=1;
                }
                else
                {
                    words.Add(item,1);
                }
            }
            foreach (string item in words.Keys)
            {
                if(words[item]%2!=0) 
                {
                    output.Add(item);
                }
                
            }
            Console.WriteLine(string.Join(", ",output));
        }
    }
}
