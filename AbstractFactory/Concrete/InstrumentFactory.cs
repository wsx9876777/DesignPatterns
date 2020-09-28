using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concrete
{
    class InstrumentFactory : IProductFactory
    {
        public ProductProviderAbstract GetProvider(string name) => name switch
        {
            "Violin" => new ViolinProvider()
        };
    }
}
