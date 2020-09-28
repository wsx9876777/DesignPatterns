﻿using Factory.Interface;
using Factory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.Concrete
{
    class FoodProvider : ProductProviderAbstract
    {
        public override IEnumerable<Product> GetAll()
        {
            return Enumerable.Repeat(new Food(), 10);
        }
    }
}
