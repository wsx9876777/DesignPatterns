using Proxy.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Concrete
{
    class HrAuth : Auth
    {
        public HrAuth(string name, string password):base(name,password)
        {

        }
        public override bool IsLegle()
        {
            if (Name == "tommy" && Password == "123456")
            {
                return true;
            }
            return false;
        }
    }
}
