using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Models;

namespace Visitor.Visitor
{
    class VipCostomer : ICarCostomer
    {
        public void Visit(FastCar fastCar)
        {
            if (fastCar.Power > 200)
            {
                Console.WriteLine($"Vip: I want buy this Car that name is {fastCar.Name} and power is {fastCar.Power}");
            }
        }
    }
}
