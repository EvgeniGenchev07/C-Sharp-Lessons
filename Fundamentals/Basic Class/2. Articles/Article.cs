using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.Articles
{
    class Article
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
        
        public string Edit
        {
            get { return this.content; }
            set { this.content = value; }
        }
        public string ChangeAuthor
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public string Rename
        {
            get { return this.title; }
            set { this.title = value; }
        }
        



        public void Output()
        {
            Console.WriteLine($"{Rename} - {Edit}: {ChangeAuthor}");
        }
    }
}
