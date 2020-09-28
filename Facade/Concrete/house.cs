using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Concrete
{
    class House
    {
        public bool IsEligible(int property) => property < 1;
    }
}
