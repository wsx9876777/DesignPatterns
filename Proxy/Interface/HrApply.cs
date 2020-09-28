using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Interface
{
    interface IHumenResource
    {
        bool Apply();
        bool Reject();
        bool IsEligible();
    }
}
