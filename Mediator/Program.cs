using Mediator.Concrete;
using Mediator.Interface;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new ChatRoom();
            var Tommy = new IParticipant("Tommy");
            var Alex = new IParticipant("Alex");
            var Stanly = new IParticipant("Stanly");
            room.Regist(Tommy);
            room.Regist(Alex);
            room.Regist(Stanly);

            Tommy.Send("Alex", "Receive", "種西瓜");
            Tommy.Send("Stanly", "Receive2" ,"養泥鰍");
            Stanly.Send("Alex", "Receive", "泥鰍肥");
            Alex.Send("Tommy", "Receive2", "吃光光");
         

        }
    }
}
