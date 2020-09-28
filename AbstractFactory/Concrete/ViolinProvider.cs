using AbstractFactory.Model;
using Factory.Interface;
using Factory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Concrete
{
    class ViolinProvider : ProductProviderAbstract
    {
        public override IEnumerable<Product> GetAll()
        {
            return Enumerable.Repeat(new Violin(), 10);
        }
    }
}
