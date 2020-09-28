using State.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Concrete
{
    class Account
	{
        private string _name;
        public string name
		{
            get { return _name; }
            set { _name = value; }
        }

        private decimal _balance;
		public decimal balance
		{
			get { return _balance; }
			set { _balance = value; }
		}
        private LevelState _LevelState;

        public LevelState LevelState
		{
            get
            {
                if (_LevelState ==null)
                {
					_LevelState =  new StateFactory().GetState<StandartState>(this);

				}
				return _LevelState;
			}
            set { _LevelState = value; }
        }
        private decimal _totalDeposite;

        public decimal TotalDeposite
		{
            get { return _totalDeposite; }
            set { _totalDeposite = value; }
        }

		public Account(string name, decimal balance)
		{
			_name = name;
			_balance = balance;
		}

		public void Deposit(decimal amount)
		{
			LevelState.Deposit(amount);
			Console.WriteLine($"level:{this.LevelState.GetType().Name}");
		}

		public void Withdraw(decimal amount)
		{
			LevelState.Withdraw(amount);
		}
	}
}
