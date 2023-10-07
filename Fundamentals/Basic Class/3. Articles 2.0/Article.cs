using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Articles_2._0
{
    internal class Article
    {
        private string title;
        private string content;
        private string author;
        public Article(string title, string content, string author)
        {
            this.title = title;
            this.content = content;
            this.author = author;
        }
        public void Output()
        {
            Console.WriteLine("{0} - {1}: {2}",this.title,this.content,this.author);
        }
    }
}
