using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observer
{
    interface IOberserver
    {
        void Perform(ISubject subject);
        void Perform(object e, ISubject subject);
    }
}
