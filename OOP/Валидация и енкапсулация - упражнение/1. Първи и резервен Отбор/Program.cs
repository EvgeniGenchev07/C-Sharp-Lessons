using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Първи_и_резервен_Отбор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Team team = new Team("Sofia");
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                team.AddPlayer(input);
            }
            team.CountPrint();
        }
    }
}
