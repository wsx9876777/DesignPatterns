using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Visitor;

namespace Visitor.Models
{
    class FastCar
    {
        public string Name { get; set; }
        public float Power { get; set; }
        public float WheelSize { get; set; }
        void Accept(ICarCostomer carCostomer)
        {
            carCostomer.Visit(this);
        }
    }
}
