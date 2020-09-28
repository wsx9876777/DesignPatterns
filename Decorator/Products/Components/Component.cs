using Decorator.Poco;
using Decorator.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Components.Component
{
    class Component : IScooter
    {
        private readonly IScooter _scooter;
        public Component(IScooter scooter, Dimension _dimension) : base(_dimension)
        {
            _scooter = scooter;
        }
        public override string GetDescription(){
            return $"加裝零件:{base._dimension.Name},Power up:{base._dimension.Power},Price up:{base._dimension.Price}";
        }

        public override double GetPower(){
            Console.WriteLine(GetDescription());
            
            return _scooter.GetPower() + base._dimension.Power;
        }

        public override decimal GetPrice()
        {
            Console.WriteLine(GetDescription());
            return _scooter.GetPrice() + base._dimension.Price;
        }
    }
}
