using Flyweight.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Concrete
{
    class FacebookAuth : IAuthiorize
    {
        public void auth()
        {
            Console.WriteLine("FacebookAuth");
        }
    }
}
