using interpreter.Concrete;
using interpreter.Interface;
using System;
using System.Collections.Generic;

namespace interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context("Hello World");
            List<IContextProtector> protectors = new List<IContextProtector>()
            {
                new ProtectorLayerOne(),
                new ProtectorLayerTwo()
            };

            foreach(var item in protectors)
            {
                item.Encrypt(context);
            }
            Console.WriteLine(context.output);
            foreach (var item in protectors)
            {
                item.Dencrypt(context);
            }
            Console.WriteLine(context.output);
        }
    }
}
