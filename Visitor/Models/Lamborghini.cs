using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Models
{
    class Lamborghini: FastCar
    {
        public Lamborghini()
        {
            base.Name = "Lamborghini";
            base.Power = 500.4f;
        }
    }
}
