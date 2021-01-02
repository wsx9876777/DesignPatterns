using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Interface
{
    interface ITarget
    {
        T ReadJson<T>() where T : new();
    }
}
