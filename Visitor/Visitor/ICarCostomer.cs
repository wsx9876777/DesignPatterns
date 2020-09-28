using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Models;

namespace Visitor.Visitor
{
    interface ICarCostomer
    {
        void Visit(FastCar fastCar);
    }
}
