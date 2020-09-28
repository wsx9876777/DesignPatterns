using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Models;

namespace Visitor.Visitor
{
    class NormalCostomer : ICarCostomer
    {
        public void Visit(FastCar fastCar)
        {
            if (fastCar.Power < 100)
            {
                Console.WriteLine($"Normal: I want buy this Car that name is {fastCar.Name} and power is {fastCar.Power}");
            }
        }
    }
}
