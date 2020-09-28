using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Concrete
{
    class Officer : IOfficerCommission
    {
        public Officer(string name, OfficerRating rating) : base(name, rating){}

        public override void Perform()
        {
            Console.WriteLine($"我:{Name} 軍官階級:{Rating} 我有小弟，我出一張嘴怎樣，小弟們做事");
            foreach (var item in base.Sobordinates)
            {
                item.Perform();
            }
            var a = this.MemberwiseClone();
        }
    }
}
