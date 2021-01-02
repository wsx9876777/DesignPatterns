using Bridge.Model;
using System;
using Bridge.Concrete;
namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = new MessageService();


            var DeclareSender = new DeclareSender();
            var ExchangeSender = new ExchangeSender();
            msg.Sender = DeclareSender;
            msg.Send("123");
            msg.Sender = ExchangeSender;
            msg.Send("321");
        }
    }
}
