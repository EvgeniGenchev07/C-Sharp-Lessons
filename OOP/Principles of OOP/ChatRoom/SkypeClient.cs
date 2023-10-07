using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    internal class SkypeClient
    {
        public string User { get; set; }
        public SkypeClient(string user)
        {
            User = user;
        }
        public void JoinChatRoom(ChatRoom chatRoom)
        {
            chatRoom.MessageSend += this.OnMessageReceived;
        }
        public void SendMess(ChatRoom chatRoom,string content)
        {
            chatRoom.PublishMessage(User, content);
        }
        protected void OnMessageReceived(object sender,ChatMessage args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{User} received {args.Author}-{args.Content} on {args.SendOn}  ");
            Console.ForegroundColor = ConsoleColor.Black;

        }
        
    }
}
