using Prototype.Concrete;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new BigHouse()
            {
                Square = 50,
                Height = 3,
                Toilet = new Toilet() { Height = 5 }
                
            };
            
            var houseClone = house.Clone() as BigHouse;
            houseClone.Square = 45;
            houseClone.Height = 2;
            houseClone.Toilet.Height = 3;
            house.build();
            houseClone.build();

        }
    }
}
