using Command.Handler;
using Command.Interface;
using Command.Type;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Concrete
{
    class CalculateCommand : ICommand
    {
        private readonly Calculator _calculator;
        private readonly OperatorEnum _operator;
        private readonly int _operand;
        public CalculateCommand(Calculator calculator, OperatorEnum @operator, int operand) => 
            (_operator, _calculator, _operand) = (@operator, calculator, operand);
        public override Calculator Execute() => _operator switch
        {
            OperatorEnum.plus => (_calculator + new Calculator(_operand)),
            OperatorEnum.minus => (_calculator - new Calculator(_operand)),
            OperatorEnum.multiply => (_calculator * new Calculator(_operand)),
            OperatorEnum.Divided => (_calculator / new Calculator(_operand)),
            _=>throw new Exception("No this Operator")
        };
        public override Calculator UnExecute() => _operator switch
        {
            OperatorEnum.plus => (_calculator - new Calculator(_operand)),
            OperatorEnum.minus => (_calculator + new Calculator(_operand)),
            OperatorEnum.multiply => (_calculator / new Calculator(_operand)),
            OperatorEnum.Divided => (_calculator * new Calculator(_operand)),
            _ => throw new Exception("No this Operator")
        };
    }
}
