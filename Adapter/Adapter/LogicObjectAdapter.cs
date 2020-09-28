using Adapter.ConcreteClass;
using Adapter.Interface;
using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Adapter.ConcreteClass
{
    class LogicObjectAdapter: ITarget
    {
        public LogicObjectAdapter()
        {

        }
        public string GetValue()
        {
            var adapee = new LogicA();
            return adapee.GetValue();
        }

        public Exclude ReadJson()
        {
            throw new NotImplementedException();
        }
    }
}
