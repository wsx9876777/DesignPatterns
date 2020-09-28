using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Concrete
{
    class Soldier : ICommission
    {
        public Soldier(string name, SoldierRating rating):base(name, rating){}
        public override void Perform()
        {
            Console.WriteLine($"我:{Name} 士兵階級:{Rating} 是砲灰 幹!");
        }
    }
}
