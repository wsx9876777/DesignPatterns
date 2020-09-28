using Factory.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interface
{

    abstract class ProductProviderAbstract
    {
       public abstract IEnumerable<Product> GetAll();
    }
}
