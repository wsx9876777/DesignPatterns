using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Models
{
    class Bmw : FastCar
    {
        public Bmw()
        {
            base.Name = "Bmw";
            base.Power = 90.4f;
        }
    }
}
