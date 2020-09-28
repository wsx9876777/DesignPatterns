using Observer.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Subject
{
    interface ISubject
    {
        string Desc { get; set; }
        List<IOberserver> Oberservers { get; set; }
        event EventHandler<ISubject> EventOberservers;
        void Attach(IOberserver oberserver);
        void Detach(IOberserver oberserver);
        void Notify(string str);
    }
}
