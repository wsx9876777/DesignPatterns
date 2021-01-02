using Bridge.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Concrete
{
    class ExchangeSender : IMessageSender
    {


        public void Conn(string ip,int port)
        {
            Console.WriteLine($"ExchangeSender Conn {ip}:{port}");
        }

        public void send(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
