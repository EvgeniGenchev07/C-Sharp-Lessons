using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List <string> article = Console.ReadLine().Split(',').ToList();  
            Article articleWithOutEdit = new Article(article[0].Trim(), article[1].Trim(), article[2].Trim());
            List<string> articlesEdit = new List<string>();
            byte n = byte.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string list = Console.ReadLine();
                string value = list;
                if (list.Contains("Edit: "))
                {
                    articleWithOutEdit.Edit= list.Remove(0, 6);
                }
                else if (list.Contains("ChangeAuthor: "))
                {
                    articleWithOutEdit.ChangeAuthor = list.Remove(0, 14);
                }
                else if (list.Contains("Rename: "))
                {
                    articleWithOutEdit.Rename = list.Remove(0, 8);
                }
            }
            articleWithOutEdit.Output();
        }
    }
}
