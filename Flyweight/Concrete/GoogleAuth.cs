using Flyweight.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Concrete
{
    class GoogleAuth : IAuthiorize
    {
        public int MyProperty { get; set; }
        public void auth()
        {
            Console.WriteLine("GoogleAuth");
        }
    }
}
