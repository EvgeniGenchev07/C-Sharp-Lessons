using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    internal class ChatMessage:EventArgs
    {
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime SendOn { get; set; }
        public ChatMessage(string content, string author)
        {
            this.Content = content;
            this.Author = author;
            this.SendOn = DateTime.Now;
        }
    }
}
