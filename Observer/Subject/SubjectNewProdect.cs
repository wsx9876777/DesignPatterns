using Observer.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Subject
{
    class SubjectNewProdect : ISubject
    {
        private string _Desc;

        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }
        private List<IOberserver> _Oberservers;

        public List<IOberserver> Oberservers
        {
            get { return _Oberservers; }
            set { _Oberservers = value; }
        }
        public event EventHandler<ISubject> EventOberservers;
        public SubjectNewProdect()
        {
            Oberservers = new List<IOberserver>();
        }

        public void Attach(IOberserver oberserver)
        {
            Oberservers.Add(oberserver);
        }
        public void Attach(Action<object,ISubject> method)
        {
            EventOberservers += new EventHandler<ISubject>(method);
        }
        public void Detach(IOberserver oberserver)
        {
            Oberservers.Remove(oberserver);
        }
        public void Detach(Action<object, ISubject> method)
        {
            EventOberservers -= new EventHandler<ISubject>(method);

        }
        public void Notify(string str)
        {
            _Desc = str;
            foreach (var item in Oberservers)
            {
                item.Perform(this);
            }
            EventOberservers(null, this);
        }
    }
}
