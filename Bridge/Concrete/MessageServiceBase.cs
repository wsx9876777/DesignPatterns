using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Model
{
    abstract class MessageServiceBase
    {
        public IMessageSender Sender { get; set; }
        public void Send(string msg) {
            Sender.send(msg);
        }
    }
}
