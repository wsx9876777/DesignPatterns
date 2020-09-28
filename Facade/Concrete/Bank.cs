using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Concrete
{
    class Bank
    {
        public bool IsEligible(int Saving) => Saving < 300000;
    }
}
