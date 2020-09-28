using Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Concrete
{
    class NormalUser : IParticipant
    {
        public NormalUser(string name):base(name)
        {

        }
    }
}
