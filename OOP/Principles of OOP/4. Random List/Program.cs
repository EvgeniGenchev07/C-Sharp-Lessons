using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Random_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomList strings = new RandomList();
            strings.Add("oesi");
            strings.Add("sidfis");
            Console.WriteLine(strings.RandomString()); 
        }
    }
}
