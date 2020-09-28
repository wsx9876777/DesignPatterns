using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Interface
{
    interface ITarget
    {
        Exclude ReadJson();
        string GetValue();
    }
}
