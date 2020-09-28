using ChainOfresponsibility.Abstract;
using ChainOfresponsibility.Model;
using System;
using System.Collections.Generic;
using System.Text;
using model = ChainOfresponsibility.Model;

namespace ChainOfresponsibility.Concrete
{
    class Developer : Capacity
    {
        public Developer(string name):base(name)
        {

        }
        public override DocumentType documentType => DocumentType.Programe;
    }
}
