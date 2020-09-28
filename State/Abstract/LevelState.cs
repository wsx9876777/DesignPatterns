using State.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Abstract
{
    abstract class LevelState
    {
        internal Account _account;
        public abstract decimal LowerLimit { get; }
        public abstract decimal UpperLimit { get; }
        public abstract void CheckState();
        protected StateFactory StateFactory = new StateFactory();

        public LevelState(Account account)
        {
            _account = account;
        }

        public virtual void Deposit(decimal amount)
        {
            Console.WriteLine($"儲值{amount}");
            _account.balance += amount;
            _account.TotalDeposite += amount;
            CheckState();
        }
        public abstract void Withdraw(decimal amount);
    }
}
