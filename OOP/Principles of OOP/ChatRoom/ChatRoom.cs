using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    internal class ChatRoom
    {
        public event EventHandler<ChatMessage> MessageSend;
        public List<string> participant { get; set; } = new List<string>();
        public string Name { get; set; }
        public ChatRoom(string name)
        {
            this.Name = name;
        }
        public void PublishMessage(string user,string content)
        {
            var args = new ChatMessage(user, content);
            MessageSend(this, args);
        }
    }
}
