using Bridge.Model;
using System;
using Bridge.Concrete;
namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = new Message() {
                Id=1,
                content="Tommy Tommy 妳好帥"
            };
            var DeclareSender = new DeclareSender("127.0.0.1", 8080);
            var ExchangeSender = new ExchangeSender("127.0.0.1", 80);
            msg.Sender = DeclareSender;
            msg.Send();
            msg.Sender = ExchangeSender;
            msg.Send();
        }
    }
}
