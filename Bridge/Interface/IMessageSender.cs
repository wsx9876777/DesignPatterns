using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Model
{
    interface IMessageSender
    {
        public void Conn(string ip, int port);
        public void send(string msg);
    }
}
