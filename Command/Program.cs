using Command.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Command.Interface;
using Command.Concrete;
using Command.Type;

namespace Command
{
    class Program
    {

        static void Main(string[] args)
        {
            var calculator = new CalculateContainer();
            calculator.compute(OperatorEnum.plus, 1);
            calculator.compute(OperatorEnum.plus, 1);
            calculator.compute(OperatorEnum.plus, 1);
            calculator.compute(OperatorEnum.plus, 1);
            calculator.compute(OperatorEnum.plus, 1);
            calculator.Undo(2);
            calculator.Redo(2);
            calculator.RedoAt(3);
            calculator.Redo(2);
        }
    }
}
