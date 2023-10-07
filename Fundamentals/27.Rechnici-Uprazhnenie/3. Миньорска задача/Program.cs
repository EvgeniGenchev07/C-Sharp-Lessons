using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Миньорска_задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MineValue = Console.ReadLine();
            Dictionary<string,int> mine = new Dictionary<string,int>();
            if (MineValue != "stop")
            {
                while (MineValue != "stop")
                {
                    int ValueCount = int.Parse(Console.ReadLine());
                    if (mine.ContainsKey(MineValue)) mine[MineValue] += ValueCount;
                    else mine.Add(MineValue, ValueCount);
                    MineValue = Console.ReadLine();
                }
                foreach (var item in mine) Console.WriteLine($"{item.Key} -> {item.Value}");
            }    
        }
    }
}
