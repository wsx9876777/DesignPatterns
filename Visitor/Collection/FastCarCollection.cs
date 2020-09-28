using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Models;
using Visitor.Visitor;

namespace Visitor.Collection
{
    class FastCarCollection : IFastCarCollection
    {
        private List<FastCar> _fastCars = new List<FastCar>();
        public void Accept(ICarCostomer customer)
        {
            _fastCars.ForEach(x =>
            {
                customer.Visit(x);
            });
        }

        public void Attach(FastCar fastCar)
        {
            _fastCars.Add(fastCar);
        }

        public void Detach(FastCar fastCar)
        {
            _fastCars.Remove(fastCar);
        }
    }
}
