using PayPal.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DZ_13
{
    internal class CreditCard
    {
        public string Number {  get; set; }
        public string Name {  get; set; }
        public DateTime Data {  get; set; }
        public int Pin {  get; set; }
        public double CreditLimit {  get; set; }
        public double Balance {  get; set; }
        public double Repl {  get; set; }
        public CreditCard(string number, string name, DateTime data,int pin,double creditlimit) 
        {
            Number = number;
            Name = name;
            Data = data;
            Pin = pin;
            CreditLimit = creditlimit;
            Repl = 0;
            Balance = Repl+ CreditLimit;      
        }
        public event Action<double> AccountReplenished; // Подія для поповнення рахунку
        public event Action<double> FundsSpent; // Подія для витрат коштів
        public event Action CreditLimitReached; // Подія для досягнення кредитного ліміту
        public event Action CreditUsageStarted; // Подія для початку використання кредитних коштів
        public event Action<int> PinChanged; // Подія для зміни PIN-коду
        public void ReplenishAccount(double amount)
        {
            Balance += amount;
            Repl += amount;
            AccountReplenished?.Invoke(amount);
        }
        public void SpendMoney(double amount)
        {
            if (Balance >= amount)
            {
                if (Repl < amount)
                {
                    CreditLimit = CreditLimit - amount+Repl;
                    Repl = 0;
                    Balance -= amount;
                    CreditUsageStarted?.Invoke();
                }
                else
                {
                    Balance -= amount;
                    Repl -= amount;
                }
                FundsSpent?.Invoke(amount);
            }
            else
            {
                Console.WriteLine("Недостатньо коштів і кредитного ліміту.");
            }

            if (Balance ==0)
            {              
                CreditLimitReached?.Invoke();
            }
        }
        public void ChangePin(int newpin)
        {
            Pin = newpin;
            PinChanged?.Invoke(newpin);
        }
        public void Display()
        {
            Console.WriteLine($"Поточний баланс складає: {Balance:C}, з них: {Repl:C}, власні кошти та {CreditLimit:C}, кредитні кошти.");
        }
    }
}
