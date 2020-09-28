using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Interface
{
    public enum SoldierRating
    {
        One = 1,
        Two = 2
    }
    abstract class ICommission: IMilitary
    {
        public string Name { get; set; }
        public SoldierRating Rating { get; set; }
        public ICommission(string name, SoldierRating rating) =>
            (Name, Rating) = (name, rating);

        public abstract void Perform();
    }
}
