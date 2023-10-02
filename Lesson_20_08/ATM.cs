using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_08
{
    internal class ATM
    {
        public static void WithdrawMoney(BankAccount account, double amount)
        {
            try
            {
                account.Withdraw(amount);
                Console.WriteLine($"Знято {amount} грн. Поточний баланс: {account.GetBalance()} грн.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
