using Decorator.Poco;
using Decorator.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Products.Moto
{
    class Scooter : IScooter
    {
        public Scooter(Dimension _dimension) : base(_dimension) { }

        public override string GetDescription() => $"moto:{base._dimension.Name},Power:{base._dimension.Power},Price:{base._dimension.Price}";
        public override double GetPower()
        {
            Console.WriteLine(GetDescription());
            return base._dimension.Power;
        }

        public override decimal GetPrice()
        {
            Console.WriteLine(GetDescription());
            return base._dimension.Price;
        }
    }
}
