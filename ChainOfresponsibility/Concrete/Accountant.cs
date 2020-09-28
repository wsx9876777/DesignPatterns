using ChainOfresponsibility.Abstract;
using ChainOfresponsibility.Model;
using System;
using System.Collections.Generic;
using System.Text;
using model = ChainOfresponsibility.Model;

namespace ChainOfresponsibility.Concrete
{
    class Accountant : Capacity
    {
        public Accountant(string name) : base(name)
        {

        }

        public override DocumentType documentType => DocumentType.Money;

    }
}
