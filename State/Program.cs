using State.Concrete;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Tommy",0);
            account.Deposit(10);
            account.Deposit(1000);
            account.Deposit(10);
            account.Withdraw(100);
            account.Withdraw(100);
            account.Deposit(10000);
            account.Withdraw(100);
        }
    }
}
