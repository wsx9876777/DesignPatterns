using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Concrete
{
    class PerformDance : IPerform
    {
        public void Perform()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
