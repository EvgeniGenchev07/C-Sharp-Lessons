using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chatRoom = new ChatRoom("Kl maini");
            var gosho = new SkypeClient("gosho");    
            var tosho = new SkypeClient("tosho");    
            var pesho = new SkypeClient("pesho");
            gosho.JoinChatRoom(chatRoom);
            pesho.JoinChatRoom(chatRoom);
            tosho.JoinChatRoom(chatRoom);
            pesho.SendMess(chatRoom, "zdr kp");
        }
    }
}
