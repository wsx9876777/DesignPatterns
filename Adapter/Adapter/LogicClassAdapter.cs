using Adapter.ConcreteClass;
using Adapter.Interface;
using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapter.ConcreteClass
{
    class LogicClassAdapter: LogicA, ITarget
    {
        public new string GetValue()
        {
            return base.GetValue();
        }

        public Exclude ReadJson()
        {
            throw new NotImplementedException();
        }
    }
}
