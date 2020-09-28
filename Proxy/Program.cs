using Proxy.Concrete;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaveProxy = new HrProxy("tommy","123454");
            leaveProxy.Apply();
        }
    }
}
