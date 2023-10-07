using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            List<string> command = Console.ReadLine().Split().ToList();
            if (command[0] == "Append")sentence = sentence.Insert(sentence.Length, " "+command[1]);
            else if (command[0] == "Remove") sentence =sentence.Remove(int.Parse(command[1]), int.Parse(command[2]));
            else if (command[0] == "Insert")sentence = sentence.Insert(int.Parse(command[1].ToString()), command[2]);
            else sentence =sentence.Replace(command[1], command[2]);
            Console.WriteLine(sentence);
        }
    }
}
