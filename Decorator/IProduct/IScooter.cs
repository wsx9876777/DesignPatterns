using Decorator.Poco;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Product
{
    abstract class IScooter
    {
        protected readonly Dimension _dimension;
        public IScooter(Dimension dimension)
        {
            _dimension = dimension;
        }
        public abstract decimal GetPrice();
        public abstract double GetPower();
        public abstract string GetDescription();
    }
}
