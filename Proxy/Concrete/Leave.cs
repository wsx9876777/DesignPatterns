using Proxy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Concrete
{
    class Leave : IHumenResource
    {
        public bool Apply()
        {
            Console.WriteLine("Apply");
            return true;
        }

        public bool IsEligible()
        {
            Console.WriteLine("IsEligible");
            return false;
        }

        public bool Reject()
        {
            Console.WriteLine("Reject");
            return true;

        }
    }
}
