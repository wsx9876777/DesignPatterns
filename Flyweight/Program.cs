using Flyweight.Factory;
using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new AuthFactory();
            var auth = factory.GetAtuh("google");
            auth = factory.GetAtuh("google");
            auth = factory.GetAtuh("google");
            auth = factory.GetAtuh("Facebook");
            auth = factory.GetAtuh("Facebook");
            auth = factory.GetAtuh("google");

            Console.WriteLine(factory.GetAuthCount()); ;
        }
    }
}
