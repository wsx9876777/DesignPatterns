using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Interface
{
    class IParticipant
    {
        private IRoom _room;

        public IRoom Room
        {
            get { return _room; }
            set { _room = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public IParticipant(string name) => (_name) = (name);
        public void Send(string to, string method, string message) {

            _room.Send(_name, to , method, message);
        }
        public void Receive(string from,string message) {
            Console.WriteLine($"Receive {from} send to {Name}:{message}");
        }
        public void Receive2(string from, string message)
        {
            Console.WriteLine($"Receive2 {from} send to {Name}:{message}");
        }
    }
}
