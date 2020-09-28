using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Interface
{
    public enum OfficerRating
    {
        General = 1,
        Colonel = 2,
        Captain = 3,
        Sergeant = 4
    }
    abstract class IOfficerCommission : IMilitary
    {
        public string Name { get; set; }
        public OfficerRating Rating { get; set; }
        public IOfficerCommission(string name, OfficerRating rating) =>
            (Name, Rating) = (name, rating);
        public List<IMilitary> Sobordinates = new List<IMilitary>();
        public abstract void Perform();
        public virtual void AddSobordinate(IMilitary commission)
        {
            Sobordinates.Add(commission);
        }
    }
}
