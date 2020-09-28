using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Abstract
{
    abstract class Auth
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public Auth(string name, string password) =>
            (Name, Password) = (name, password);
        public abstract bool IsLegle();
    }
}
