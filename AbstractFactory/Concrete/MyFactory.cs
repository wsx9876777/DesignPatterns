using AbstractFactory.Interface;
using Factory.Concrete;
using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Concrete
{
    class MyFactory : MyFactoryAbstract
    {
        public IProductFactory CreateFactory(string name) => name switch
        {
            "Product" => new ProductFactory(),
            "Instrument" => new InstrumentFactory()
        };
    }
}
