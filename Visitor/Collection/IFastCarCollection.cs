using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Models;
using Visitor.Visitor;

namespace Visitor.Collection
{
    interface IFastCarCollection
    {
        void Attach(FastCar fastCar);
        void Detach(FastCar fastCar);
        void Accept(ICarCostomer customer);
    }
}
