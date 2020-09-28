using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Model
{
    class Message
    {
        public int Id { get; set; }
        public string content { get; set; }
        public MessageSender Sender { get; set; }
        public virtual void Send() => Sender.send(this);
    }
}
