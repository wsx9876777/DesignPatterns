using Factory.Concrete;
using Factory.Interface;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductFactory factory = new ProductFactory();
            ProductProviderAbstract ClothProvider = factory.GetProvider("Cloth");
            ProductProviderAbstract FootProvider = factory.GetProvider("Food");
            var cloths = ClothProvider.GetAll();
            var food = FootProvider.GetAll();

        }
    }
}
