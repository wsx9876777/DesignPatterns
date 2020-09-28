using Composite.Concrete;
using Composite.Interface;
using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var tommy = new Officer("Tommy", OfficerRating.General);
            var sammy = new Officer("sammy", OfficerRating.Captain);
            var Chris = new Soldier("Chris", SoldierRating.Two);

            tommy.AddSobordinate(sammy);
            sammy.AddSobordinate(Chris);


            tommy.Perform();

        }
    }
}
