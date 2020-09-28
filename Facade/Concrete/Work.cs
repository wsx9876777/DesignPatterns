using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Concrete
{
    class Work
    {
        public bool IsEligible(int income) => income < 600000;
    }
}
