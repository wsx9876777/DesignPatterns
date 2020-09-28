using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Concrete
{
    class GovermentSubsidy
    {
        readonly Bank back = new Bank();
        readonly House House = new House();
        readonly Work Work = new Work();
        public bool isEligible(People people)
        {
            
            if (back.IsEligible(people.Saving) &&
                House.IsEligible(people.HouseProperty) &&
                Work.IsEligible(people.AnnualIncome))
            {
                return true;
            }
            return false;

        }
    }
}
