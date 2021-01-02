using System;
using Visitor.Collection;
using Visitor.Models;
using Visitor.Visitor;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IFastCarCollection fastCarCollection = new FastCarCollection();
            FastCar lamborghini = new Lamborghini();
            FastCar bmw = new Bmw();
            FastCar benz = new Benz();
            fastCarCollection.Attach(lamborghini);
            fastCarCollection.Attach(bmw);
            fastCarCollection.Attach(benz);

            ICarCostomer normalCostomer = new NormalCostomer();
            ICarCostomer vipCostomer = new VipCostomer();
            fastCarCollection.Accept(normalCostomer);
           
            //fastCarCollection.Detach(bmw);
            fastCarCollection.Accept(vipCostomer);

        }
    }
}
