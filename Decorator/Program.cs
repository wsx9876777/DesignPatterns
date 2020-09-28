using Decorator.Components.Component;
using Decorator.Poco;
using Decorator.Product;
using Decorator.Products.Moto;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            var jetSR = new Dimension() { Name = "JetSR",Power=10.5,Price=84000 };
            IScooter scooter = new Scooter(jetSR);

            var BATTERY = new Dimension() { Name = "BATTERY", Power = 0.2, Price = 1200 };
            scooter = new Component(scooter, BATTERY);
            var FRAME = new Dimension() { Name = "FRAME", Power = 0.2, Price = 1200 };
            scooter = new Component(scooter, FRAME);
            var CARBURETOR = new Dimension() { Name = "CARBURETOR", Power = 0.2, Price = 1200 };
            scooter = new Component(scooter, CARBURETOR);
            Console.WriteLine(scooter.GetPrice());
        }
    }
}
