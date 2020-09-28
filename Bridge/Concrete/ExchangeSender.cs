using Bridge.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Concrete
{
    class ExchangeSender : MessageSender
    {
        public ExchangeSender(string ip, int port) : base(ip, port) { }
        public override void Conn()
        {
            Console.WriteLine($"Conn ExchangeServer {Ip} {Port}");
        }

        public override void send(Message message)
        {
            Console.WriteLine($"Send ExchangeServer message:{message.content}");
        }
    }
}
