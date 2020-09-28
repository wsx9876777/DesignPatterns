using State.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Concrete
{
    class StandartState : LevelState
    {
        public StandartState(Account account) : base(account) { }
        public override decimal LowerLimit => 1000;

        public override decimal UpperLimit => 10000;
        public override void Withdraw(decimal amount)
        {
            if (_account.balance > amount)
            {
                Console.WriteLine($"免手續費");
                Console.WriteLine($"匯出{amount}");

                _account.balance -= amount;
                CheckState();
            }
            else
            {
                Console.WriteLine("餘額不足");
            }
            
        }

        public override void CheckState()
        {
            if (_account.TotalDeposite < LowerLimit)
            {
                base._account.LevelState =
                    StateFactory.GetState<OverDrawn>(base._account);
            }
            else if (_account.TotalDeposite > UpperLimit)
            {
                base._account.LevelState =
                    StateFactory.GetState<PremiumState>(base._account);
            }
        }
    }
}
