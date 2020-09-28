using State.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Concrete
{
    class PremiumState : LevelState
    {
        public PremiumState(Account account) : base(account) { }
        public override decimal LowerLimit => 10000;

        public override decimal UpperLimit => 0;
        public override void Withdraw(decimal amount)
        {
            if (_account.balance > amount)
            {

                Console.WriteLine($"反水百分之0.3:{amount * 0.003m}");
                Console.WriteLine($"匯出{amount}==>匯出{amount * 1.003m}");
                _account.balance -= amount * 1.003m;
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
                    StateFactory.GetState<StandartState>(base._account);
            }
        }
    }
}
