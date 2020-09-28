using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Concrete
{
    class Performance
    {
        private IPerform _perform;
        
        public void Perform()
        {

            _perform.Perform();
        }
        public void SetPerformance(IPerform perform)
            => _perform = perform;
    }
}
