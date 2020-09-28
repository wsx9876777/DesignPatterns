using System;
using System.Collections.Generic;
using System.Text;

namespace Command.test.Handler
{
    public readonly struct Calculator
    {
        public readonly int num;
        public Calculator(int a) => num = a;
        public static Calculator operator +(Calculator a, Calculator b)
            => new Calculator(a.num + b.num);
        public static Calculator operator -(Calculator a, Calculator b)
            => new Calculator(a.num - b.num);
        public static Calculator operator *(Calculator a, Calculator b)
            => new Calculator(a.num * b.num);
        public static Calculator operator /(Calculator a, Calculator b)
            => new Calculator(a.num / b.num);
        public int total => num;
    }
}
