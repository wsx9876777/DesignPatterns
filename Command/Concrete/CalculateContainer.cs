using Command.Handler;
using Command.Type;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ICommand = Command.Interface;

namespace Command.Concrete
{
    class CalculateContainer
    {
        List<ICommand::ICommand> _commands = new List<ICommand::ICommand>();
        Calculator _calculator = new Calculator(0);
        int _cuurent;
        public void Redo(uint num) {
            var count = _commands.Count;
            while (_cuurent < count && num <= count)
            {
                
                var cmd = _commands[_cuurent];
                _calculator = cmd.Execute();
                _cuurent++; num++;
                Console.WriteLine($"Redo {_calculator.total}");
            };
        }
        public void Undo(int num) {
            var count = _commands.Count;
            while (_cuurent > -1 && num >0)
            {
                _cuurent--;num--;
                var cmd = _commands[_cuurent-1];
                _calculator = cmd.Execute();
                Console.WriteLine($"Undo {_calculator.total}");
            };
        }
        public void RedoAt(uint num)
        {
            var cmd = _commands[(int)num - 1];
            _calculator = cmd.Execute();
            _cuurent = (int)num;
            Console.WriteLine($"RedoAt {_calculator.total}");
        }
        public void compute(OperatorEnum operatorEnum, int operand) {
            var cmd = new CalculateCommand(_calculator, operatorEnum, operand);
            _calculator = cmd.Execute();
            _commands.Add(cmd);
            _cuurent++;
            Console.WriteLine(_calculator.total);
        }
    }
}
