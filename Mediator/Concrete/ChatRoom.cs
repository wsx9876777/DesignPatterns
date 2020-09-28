using Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Mediator.Concrete
{
    class ChatRoom : IRoom
    {
        public override void Regist(IParticipant participant)
        {
            base.participants[participant.Name] = participant;
            participant.Room = this;
        }

        public override void Send(string from, string to, string method, string message)
        {
            IParticipant receiver = base.participants[to];
            var a = new[] { from, message };
            if (receiver != null){
                receiver.GetType().InvokeMember(
                    name: method,
                    invokeAttr: BindingFlags.InvokeMethod,
                    binder: null,
                    target: receiver,
                    args: a);


                //receiver.Receive(from, message);
            }
        }
    }
}
