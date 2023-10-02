using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_08
{
    internal class BankAccount
    {
        private double balance;

        public BankAccount(double initBalance)
        {
            if (initBalance < 0)
            {
                throw new ArgumentException("Початковий баланс не може бути від'ємним.");
            }
            balance = initBalance;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Сума для внесення не може бути від'ємною.");
            }
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Сума для зняття не може бути від'ємною.");
            }

            if (amount > balance)
            {
                throw new InsufficientFundsException("Недостатньо коштів для зняття.");
            }

            balance -= amount;
        }
    }
}
