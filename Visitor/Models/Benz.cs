using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Models
{
    class Benz : FastCar
    {
        public Benz()
        {
            base.Name = "Benz";
            base.Power = 250.75457575f;
        }
    }
}
