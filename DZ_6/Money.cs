using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DZ_6
{
    internal class Money
    {
        private int _money;
        private int _pennies;
        private string _name;        

        public Money(int money, int pennies, string name) 
        {
            _money = money;
            _pennies = pennies;
            _name = name;
        }
        public void Display()
        {
            Console.WriteLine($"{_money} {_name} {_pennies} центів");
        }
        public void SetAmount(int money, int pennies, string name)
        {
            _money = money;
            _pennies = pennies;
            _name = name;
        }
        public int GetMoney() 
        {
            return _money;
        }
        public int GetPennies() 
        {
            return _pennies;
        }
        public string GetName() 
        {
            return _name;
        }
    }
}
