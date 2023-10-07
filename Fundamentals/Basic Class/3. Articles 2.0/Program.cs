using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Article[] articles = new Article[n];
            for (int i = 0; i < n; i++)
            {
                List<string> articleString = Console.ReadLine().Split(',').ToList();
                articles[i] = new Article(articleString[0].Trim(), articleString[1].Trim(), articleString[2].Trim());

            }
            for (int i = 0; i < n; i++)
            {
                articles[i].Output();
            }
        }
    }
}
