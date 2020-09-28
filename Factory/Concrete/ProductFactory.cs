using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Concrete
{
    class ProductFactory : IProductFactory
    {
        public ProductProviderAbstract GetProvider(string name) => name switch
        {
            "Cloth" => new ClothProvider(),
            "Food" => new ClothProvider(),
        };
    }
}
