using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interface
{
    interface MyFactoryAbstract
    {
        IProductFactory CreateFactory(string name);
    }
}
