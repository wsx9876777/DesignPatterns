using State.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Concrete
{
    class OverDrawn : LevelState
    {
        public OverDrawn(Account account) : base(account) { }
        public override decimal LowerLimit => 0;

        public override decimal UpperLimit => 1000;


        public override void Withdraw(decimal amount)
        {
            if (_account.balance > amount)
            {
                Console.WriteLine($"收取手續費百分之0.5:{amount * 0.005m}");
                Console.WriteLine($"匯出{amount}==>{amount * 0.995m}");
                _account.balance -= amount * 0.995m;
                CheckState();
            }
            else
            {
                Console.WriteLine("餘額不足");
            }
            
        }
        public override void CheckState()
        {
            if (_account.TotalDeposite > UpperLimit)
            {
                base._account.LevelState = StateFactory.GetState<StandartState>(base._account);
            }
        }
    }
}
