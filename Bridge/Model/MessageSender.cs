using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Model
{
    abstract class MessageSender
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public MessageSender(string ip, int port) => (Ip, Port) = (ip, port);

        public abstract void Conn();
        public abstract void send(Message message);
    }
}
