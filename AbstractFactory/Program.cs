using AbstractFactory.Concrete;
using AbstractFactory.Interface;
using Factory.Concrete;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFactoryAbstract ipfa = new MyFactory();
            var factory = ipfa.CreateFactory("Instrument");
            var instrumentProvider = factory.GetProvider("Violin");
            var violin = instrumentProvider.GetAll();
        }
    }
}
