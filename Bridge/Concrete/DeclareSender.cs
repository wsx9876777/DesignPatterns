using Bridge.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Concrete
{
    class DeclareSender : MessageSender
    {
        public DeclareSender(string ip, int port) : base(ip, port) { }
        public override void Conn()
        {
            Console.WriteLine($"Conn DeclareServer {Ip} {Port}");
        }

        public override void send(Message message)
        {
            Console.WriteLine($"Send DeclareServer message:{message.content}");
        }
    }
}
