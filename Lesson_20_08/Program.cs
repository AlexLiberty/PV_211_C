using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_20_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            //byte data = Convert.ToByte(Console.ReadLine());
            //try
            //{
            //    byte result = checked((byte)Math.Pow(data, 10));
            //    Console.WriteLine(result);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("OverflowException");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception");
            //}

            try
            {
                Console.Write("Введіть початковий баланс банківського рахунку: ");
                if (double.TryParse(Console.ReadLine(), out double initBalance))
                {
                    BankAccount account = new BankAccount(initBalance);
                    Console.WriteLine($"Поточний баланс: {account.GetBalance()} грн.");

                    do
                    {
                        Console.Write("Введіть суму для зняття: ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawalAmount))
                        {
                            if (account.GetBalance() == 0)
                            {
                                Console.WriteLine("Баланс дорівнює "+ account.GetBalance()+"\n Вихід з програми.");
                                break; 
                            }
                            ATM.WithdrawMoney(account, withdrawalAmount);
                        }
                        else
                        {
                            Console.WriteLine("Некоректний ввід для суми зняття.");
                        }
                    } while (true);
                }
                else
                {
                    Console.WriteLine("Некоректний ввід для початкового балансу.");
                }
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
