using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Interface
{
    abstract class IRoom
    {
        public Dictionary<string,IParticipant> participants
            = new Dictionary<string, IParticipant>();
        public abstract void Regist(IParticipant participant);

        public abstract void Send(string from,string to, string method, string message);
    }
}
