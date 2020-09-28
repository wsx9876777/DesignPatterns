using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interface
{
    interface IProductFactory
    {
        public ProductProviderAbstract GetProvider(string name);
    }
}
