using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class Product
    {
        private string _name;
        private Money _price;

        public Product(string name, Money price)
        {
            _name = name;
            _price = price;
        }
        public void ReducePrice(int money, int pennies, string name)
        {
            int totalPennies = _price.GetPennies() + money * 100 + pennies;
            int newMoney = totalPennies / 100;
            int newPennies = totalPennies % 100;

            _price.SetAmount(newMoney, newPennies, name);
        }
        public void Display()
        {
            Console.WriteLine($"Назва товару: {_name}");
            Console.Write("Ціна: ");
            _price.Display();
        }
    }
}
